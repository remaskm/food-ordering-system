using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                categoryComboBox.Items.Clear();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Category FROM Meal", con);
                SqlDataReader reader = cmd.ExecuteReader();

                bool hasCategories = false;
                while (reader.Read())
                {
                    string category = reader["Category"].ToString();
                    if (!string.IsNullOrEmpty(category))
                    {
                        categoryComboBox.Items.Add(category);
                        hasCategories = true;
                    }
                }

                reader.Close();

                if (!hasCategories)
                {
                    MessageBox.Show("No categories found in the database. Make sure you have added meals with categories.");
                }

                sortOrderComboBox.Items.Clear();
                sortOrderComboBox.Items.Add("Lowest to Highest");
                sortOrderComboBox.Items.Add("Highest to Lowest");
                sortOrderComboBox.SelectedIndex = 0;

                // NEW: Hide grids on form load
                nameResultsGrid.Visible = false;
                priceCatResultsGrid.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form: " + ex.Message);
            }
        }


        // Helper method to load all meals initially
        private void LoadAllMeals()
        {
            try
            {
                string query = "SELECT * FROM Meal";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No meals found in the database.");
                }
                else
                {
                    // Set both data grids to show all meals initially
                    nameResultsGrid.DataSource = dt;
                    priceCatResultsGrid.DataSource = dt.Copy();

                    // Make sure the DataGridView is properly showing data
                    nameResultsGrid.Refresh();
                    priceCatResultsGrid.Refresh();

                    // Debug info
                    Console.WriteLine($"Loaded {dt.Rows.Count} meals into the grids");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meals: " + ex.Message);
            }
        }

        private void searchByNameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                string nameInput = nameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(nameInput))
                {
                    MessageBox.Show("Please enter a meal name to search.");
                    return;
                }

                string query = "SELECT * FROM Meal WHERE Meal_name LIKE @name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", "%" + nameInput + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No meals found matching the search criteria.");
                    nameResultsGrid.Visible = false;
                    nameResultsGrid.DataSource = null;
                    return;
                }

                nameResultsGrid.DataSource = dt;
                nameResultsGrid.Visible = true; // Show grid
                nameResultsGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching by name: " + ex.Message);
            }
        }


        private void searchByPriceCatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                if (categoryComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a category.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(minPriceTextBox.Text) || string.IsNullOrWhiteSpace(maxPriceTextBox.Text))
                {
                    MessageBox.Show("Please enter both minimum and maximum prices.");
                    return;
                }

                decimal minPrice, maxPrice;
                if (!decimal.TryParse(minPriceTextBox.Text, out minPrice) || !decimal.TryParse(maxPriceTextBox.Text, out maxPrice))
                {
                    MessageBox.Show("Please enter valid numbers for min and max prices.");
                    return;
                }

                string orderClause = "";
                if (sortOrderComboBox.SelectedItem.ToString() == "Lowest to Highest")
                    orderClause = "ORDER BY Price ASC";
                else if (sortOrderComboBox.SelectedItem.ToString() == "Highest to Lowest")
                    orderClause = "ORDER BY Price DESC";

                string query = $"SELECT * FROM Meal WHERE Category = @cat AND Price BETWEEN @min AND @max {orderClause}";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cat", categoryComboBox.Text);
                cmd.Parameters.AddWithValue("@min", minPrice);
                cmd.Parameters.AddWithValue("@max", maxPrice);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No meals found matching the search criteria.");
                    priceCatResultsGrid.Visible = false;
                    priceCatResultsGrid.DataSource = null;
                    return;
                }

                priceCatResultsGrid.DataSource = dt;
                priceCatResultsGrid.Visible = true; // Show grid
                priceCatResultsGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching by price and category: " + ex.Message);
            }
        }


        private void backBtn_Click(object sender, EventArgs e) // Back button
        {
            if (con.State == ConnectionState.Open)
                con.Close();

            customer_form cform = new customer_form();
            cform.Show();
            this.Hide();
        }

        // Make sure the connection is closed when the form is closed
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (con != null && con.State == ConnectionState.Open)
                con.Close();
        }

        // Optional: Empty event handlers
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void maxPriceTextBox_TextChanged(object sender, EventArgs e) { }
        private void minPriceTextBox_TextChanged(object sender, EventArgs e) { }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void sortOrderComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void nameResultsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void priceCatResultsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void searchByCategoryPrice_Click(object sender, EventArgs e) { }

            private void orderNowBtn_Click(object sender, EventArgs e)
        {
            if (Session.Role == "customer")
            {
                OrderForm orderForm = new OrderForm();
                orderForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please sign in as a customer to place orders");
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
    }
    
}