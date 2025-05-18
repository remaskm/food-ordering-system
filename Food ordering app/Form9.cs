using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class OrderForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");
        private DataTable orderItems = new DataTable();
        private int currentOrderId = -1;

        public OrderForm()
        {
            InitializeComponent();
            InitializeOrderItemsTable();
        }

        private void InitializeOrderItemsTable()
        {
            orderItems.Columns.Add("MealName", typeof(string));
            orderItems.Columns.Add("Quantity", typeof(int));
            orderItems.Columns.Add("Price", typeof(decimal));
            orderItems.Columns.Add("Total", typeof(decimal));

            orderDetailsGrid.DataSource = orderItems;
            orderDetailsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderDetailsGrid.ReadOnly = true;
            orderDetailsGrid.Visible = false;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                LoadAvailableMeals();
                LoadPendingOrders();
                confirmOrderBtn.Visible = false;
                proceedToPaymentBtn.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void LoadAvailableMeals()
        {
            try
            {
                string query = "SELECT Meal_name FROM Meal WHERE Availability = 1";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                mealComboBox.DataSource = dt;
                mealComboBox.DisplayMember = "Meal_name";
                mealComboBox.ValueMember = "Meal_name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meals: " + ex.Message);
            }
        }

        private void LoadPendingOrders()
        {
            try
            {
                string query = @"SELECT ORDER_ID FROM [ORDER] 
                        WHERE USER_ID = @userId 
                        AND STATUS = 'Pending'
                        AND ORDER_ID IN (
                            SELECT DISTINCT ORDER_ID 
                            FROM ORDER_DETAILS
                        )"; // Only orders with items

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                // Add check for empty results
                if (dt.Rows.Count == 0)
                {
                    cancelOrderComboBox.DataSource = null;
                    cancelOrderComboBox.Items.Clear();
                    cancelOrderComboBox.Text = "No pending orders";
                    cancelOrderBtn.Enabled = false;
                }
                else
                {
                    cancelOrderComboBox.DataSource = dt;
                    cancelOrderComboBox.DisplayMember = "ORDER_ID";
                    cancelOrderComboBox.ValueMember = "ORDER_ID";
                    cancelOrderBtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending orders: " + ex.Message);
            }
        }

        private void addToOrderBtn_Click(object sender, EventArgs e)
        {
            if (mealComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a meal");
                return;
            }

            try
            {
                // Get meal price
                string priceQuery = "SELECT Price FROM Meal WHERE Meal_name = @meal";
                SqlCommand priceCmd = new SqlCommand(priceQuery, con);
                priceCmd.Parameters.AddWithValue("@meal", mealComboBox.SelectedValue);
                decimal price = (decimal)priceCmd.ExecuteScalar();

                // Add to order items
                DataRow row = orderItems.NewRow();
                row["MealName"] = mealComboBox.SelectedValue;
                row["Quantity"] = quantityUpDown.Value;
                row["Price"] = price;
                row["Total"] = price * (int)quantityUpDown.Value;
                orderItems.Rows.Add(row);

                // Update UI
                orderDetailsGrid.Visible = true;
                orderDetailsGrid.Refresh();
                confirmOrderBtn.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to order: " + ex.Message);
            }
        }

        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderItems.Rows.Count == 0)
            {
                MessageBox.Show("No items in order");
                return;
            }

            try
            {
                // Create order
                string orderQuery = @"INSERT INTO [ORDER] (USER_ID, ORDER_DATE, STATUS) 
                                     OUTPUT INSERTED.ORDER_ID 
                                     VALUES (@userId, @date, 'Pending')";
                SqlCommand orderCmd = new SqlCommand(orderQuery, con);
                orderCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                orderCmd.Parameters.AddWithValue("@date", DateTime.Now);
                currentOrderId = (int)orderCmd.ExecuteScalar();

                // Add order details
                foreach (DataRow row in orderItems.Rows)
                {
                    string detailQuery = @"INSERT INTO ORDER_DETAILS (ORDER_ID, MEAL_NAME, QUANTITY) 
                                         VALUES (@orderId, @meal, @qty)";
                    SqlCommand detailCmd = new SqlCommand(detailQuery, con);
                    detailCmd.Parameters.AddWithValue("@orderId", currentOrderId);
                    detailCmd.Parameters.AddWithValue("@meal", row["MealName"]);
                    detailCmd.Parameters.AddWithValue("@qty", row["Quantity"]);
                    detailCmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Order confirmed! Your order ID is: {currentOrderId}");
                orderItems.Clear();
                LoadPendingOrders();
                proceedToPaymentBtn.Visible = true;
                orderDetailsGrid.Visible = false;
                confirmOrderBtn.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error confirming order: " + ex.Message);
            }
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            if (cancelOrderComboBox.SelectedIndex == -1 || cancelOrderComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid order to cancel");
                return;
            }

            try
            {
                int orderId = (int)cancelOrderComboBox.SelectedValue;

                // Delete order details first
                string detailQuery = "DELETE FROM ORDER_DETAILS WHERE ORDER_ID = @orderId";
                SqlCommand detailCmd = new SqlCommand(detailQuery, con);
                detailCmd.Parameters.AddWithValue("@orderId", orderId);
                detailCmd.ExecuteNonQuery();

                // Then delete order
                string orderQuery = "DELETE FROM [ORDER] WHERE ORDER_ID = @orderId";
                SqlCommand orderCmd = new SqlCommand(orderQuery, con);
                orderCmd.Parameters.AddWithValue("@orderId", orderId);
                orderCmd.ExecuteNonQuery();

                MessageBox.Show("Order cancelled successfully");
                LoadPendingOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling order: " + ex.Message);
            }
        }

        private void proceedToPaymentBtn_Click(object sender, EventArgs e)
        {
            if (currentOrderId == -1)
            {
                MessageBox.Show("No order to proceed with");
                return;
            }

            try
            {
                // Verify order exists and get total amount first
                string verifyQuery = @"SELECT SUM(m.PRICE * od.QUANTITY) 
                             FROM ORDER_DETAILS od
                             JOIN MEAL m ON od.MEAL_NAME = m.MEAL_NAME
                             WHERE od.ORDER_ID = @orderId";

                using (SqlCommand cmd = new SqlCommand(verifyQuery, con))
                {
                    cmd.Parameters.AddWithValue("@orderId", currentOrderId);
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        MessageBox.Show("Order has no items or doesn't exist");
                        return;
                    }

                    decimal totalAmount = Convert.ToDecimal(result);
                    PaymentForm paymentForm = new PaymentForm(currentOrderId);
                    paymentForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error preparing payment: {ex.Message}");
            }
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            customer_form cform = new customer_form();
            cform.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}