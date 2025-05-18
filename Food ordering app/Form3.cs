using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class test_form : Form
    {
        public test_form()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");
        private void test_form_Load(object sender, EventArgs e)
        {

            if (Session.Role == "admin")
            {
                edit.Visible = true;
            }
            con.Open();
            show();
        }

        public void show()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Meal", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            con.Close();
            form1.Show();
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            edit_menu eform = new edit_menu();
            con.Close();
            eform.Show();
            this.Hide();
        }

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
                MessageBox.Show("Please sign in as a customer to place orders", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}