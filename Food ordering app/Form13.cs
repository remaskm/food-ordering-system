using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class CustomerAnalyticsForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");

        public CustomerAnalyticsForm()
        {
            InitializeComponent();
        }

        private void CustomerAnalyticsForm_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void btnCustomerSpending_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT TOP 10 u.USER_ID, u.USER_NAME, 
                               SUM(m.PRICE * od.QUANTITY) AS TotalSpent
                               FROM [USER] u
                               JOIN [ORDER] o ON u.USER_ID = o.USER_ID
                               JOIN ORDER_DETAILS od ON o.ORDER_ID = od.ORDER_ID
                               JOIN MEAL m ON od.MEAL_NAME = m.MEAL_NAME
                               WHERE o.ORDER_DATE >= DATEADD(month, -3, GETDATE())
                               AND o.STATUS = 'Paid'
                               GROUP BY u.USER_ID, u.USER_NAME
                               ORDER BY TotalSpent DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                lblTitle.Text = "Top 10 Customers by Spending (Last 3 Months)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnTopCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT TOP 1 u.USER_ID, u.USER_NAME, 
                               SUM(m.PRICE * od.QUANTITY) AS MonthlyTotal
                               FROM [USER] u
                               JOIN [ORDER] o ON u.USER_ID = o.USER_ID
                               JOIN ORDER_DETAILS od ON o.ORDER_ID = od.ORDER_ID
                               JOIN MEAL m ON od.MEAL_NAME = m.MEAL_NAME
                               WHERE o.ORDER_DATE >= DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0)
                               AND o.STATUS = 'Paid'
                               GROUP BY u.USER_ID, u.USER_NAME
                               ORDER BY MonthlyTotal DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                lblTitle.Text = "Top Customer This Month";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnOrderCounts_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT u.USER_ID, u.USER_NAME, u.PHONE, 
                               COUNT(o.ORDER_ID) AS TotalOrders,
                               SUM(CASE WHEN o.ORDER_DATE >= DATEADD(month, -3, GETDATE()) THEN 1 ELSE 0 END) AS RecentOrders
                               FROM [USER] u
                               LEFT JOIN [ORDER] o ON u.USER_ID = o.USER_ID AND o.STATUS = 'Paid'
                               GROUP BY u.USER_ID, u.USER_NAME, u.PHONE
                               ORDER BY TotalOrders DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                lblTitle.Text = "Customer Order Counts";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}