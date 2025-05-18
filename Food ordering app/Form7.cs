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
    public partial class edit_menu : Form
    {
        public edit_menu()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO meal (Meal_name, Category, Price, Availability, Season, Calories, Description) VALUES (@name, @cat, @price, @avail, @season, @cal, @des)", con);

                cmd.Parameters.AddWithValue("@name", name_box.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(price_box.Text));
                cmd.Parameters.AddWithValue("@cat", cat_box.Text);
                cmd.Parameters.AddWithValue("@cal", cal_box.Text);
                cmd.Parameters.AddWithValue("@season", season_box.Text);
                cmd.Parameters.AddWithValue("@des", description_box.Text);
                cmd.Parameters.AddWithValue("@avail", checkBox1.Checked);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Menu item added successfully!");

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
                SqlCommand cmd = new SqlCommand("DELETE FROM meal WHERE meal_name = @name", con);

                cmd.Parameters.AddWithValue("@name", name_box.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Menu item deleted successfully!");

                }
                else
                {
                    MessageBox.Show("meal not found.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("UPDATE meal SET Meal_name = @name, Category = @cat, Price = @price, Availability = @avail, Season = @season, Calories = @cal, Description = @des where meal_name = @name", con);

                cmd.Parameters.AddWithValue("@name", name_box.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(price_box.Text));
                cmd.Parameters.AddWithValue("@cat", cat_box.Text);
                cmd.Parameters.AddWithValue("@cal", cal_box.Text);
                cmd.Parameters.AddWithValue("@season", season_box.Text);
                cmd.Parameters.AddWithValue("@des", description_box.Text);
                cmd.Parameters.AddWithValue("@avail", checkBox1.Checked);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Menu updated successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            admin_form aform = new admin_form();
            aform.Show();
            this.Hide();
        }

        private void edit_menu_Load(object sender, EventArgs e)
        {
            con.Open();
        }





        /* MEAL_NAME            varchar(255)         not null,
CATEGORY             varchar(255)         not null,
PRICE                money                not null,
DESCRIPTION          varchar(255)         not null,
CALORIES             varchar(255)         not null,
AVAILABILITY         bit                  not null,
SEASON*/

    }
}
