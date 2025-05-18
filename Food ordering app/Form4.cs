using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
           // con.Close();
            form1.Show();
            this.Hide();
        }

        private void Cedit_Click(object sender, EventArgs e)
        {
            edit_user form50 = new edit_user();
            form50.Show();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            test_form form2 = new test_form();
           // con.Close();
            form2.Show();
            this.Hide();
        }
        // In admin_form.cs
        private void btnMealAnalytics_Click(object sender, EventArgs e)
        {
            MealAnalyticsForm mealForm = new MealAnalyticsForm();
            mealForm.Show();
        }

        private void btnCustomerAnalytics_Click(object sender, EventArgs e)
        {
            CustomerAnalyticsForm customerForm = new CustomerAnalyticsForm();
            customerForm.Show();
        }
    }
}
