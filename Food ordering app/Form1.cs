using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        customer_form cform = new customer_form();
        admin_form aform = new admin_form();

        // Connection string defined here but not opened until needed
        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // Removed con.Open() to avoid crashing on startup if connection fails
            // Optionally test connection here using try-catch if needed
        }

        public bool CustomerExists(int ID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True"))
                {
                    string query = "SELECT USER_ID FROM [USER] WHERE USER_ID = @id and Role = 'customer'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", ID);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error checking customer: " + ex.Message);
                return false;
            }
        }

        public bool AdminExists(int ID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True"))
                {
                    string query = "SELECT USER_ID FROM [USER] WHERE USER_ID = @id and Role = 'admin'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", ID);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking admin: " + ex.Message);
                return false;
            }
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            try
            {
                int userId;

                if (int.TryParse(id_box.Text, out userId))
                {
                    Session.CurrentUserId = userId;

                    if (CustomerExists(userId))
                    {
                        cform.Show();
                        this.Hide();
                        Session.Role = "customer";
                    }
                    else if (AdminExists(userId))
                    {
                        aform.Show();
                        this.Hide();
                        Session.Role = "admin";
                    }
                    else
                    {
                        MessageBox.Show("User does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void test_Click(object sender, EventArgs e)
        {
            test_form form2 = new test_form();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
