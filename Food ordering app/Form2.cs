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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Food_ordering_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
        }
        private void sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [User] (USER_ID, USER_NAME, PHONE, ROLE) VALUES (@id, @name, @phone, @role)", con);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Id_box.Text));
                cmd.Parameters.AddWithValue("@name", Name_box.Text);
                cmd.Parameters.AddWithValue("@phone", Convert.ToInt32(Phone_box.Text));
                cmd.Parameters.AddWithValue("@role", check_role.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User added successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}