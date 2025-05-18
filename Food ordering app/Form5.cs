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
    public partial class customer_form : Form
    {
        public customer_form()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void customer_form_Load(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            edit_user form50 = new edit_user();
            form50.Show();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            test_form form2 = new test_form();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void orderNowBtn_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            FeedbackForm fform = new FeedbackForm();
            fform.Show();
            this.Hide();
        }
    }
}
