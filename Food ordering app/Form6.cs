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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Food_ordering_app
{
    public partial class edit_user : Form
    {
        public edit_user()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");

        private void Form6_Load(object sender, EventArgs e)
        {
            con.Open();
     
        }
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;

                if (Session.Role == "customer")
                {
                    
                    cmd = new SqlCommand("UPDATE [user] SET user_Name = @name, Phone = @phone, User_ID = @id WHERE User_ID = @old_id", con);
                    cmd.Parameters.AddWithValue("@old_id", Session.CurrentUserId);

                }
                else
                {
                    cmd = new SqlCommand("UPDATE [user] SET user_Name = @name, Phone = @phone  WHERE User_ID = @id", con);
                }

                cmd.Parameters.AddWithValue("@id", Id_box.Text);
                cmd.Parameters.AddWithValue("@name", Name_box.Text);
                cmd.Parameters.AddWithValue("@phone", Convert.ToInt32(Phone_box.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("User data updated successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [user] WHERE user_id = @id", con);


                if (Session.Role == "customer")
                {
                    cmd.Parameters.AddWithValue("@id", Session.CurrentUserId);
                }else
                {
                    cmd.Parameters.AddWithValue("@id", Id_box.Text);
                }
                    int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("user deleted successfully!");

                }
                else
                {
                    MessageBox.Show("user not found.");
                }

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


    }
}
