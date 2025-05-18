using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class MealAnalyticsForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");

        public MealAnalyticsForm()
        {
            InitializeComponent();
        }

        private void MealAnalyticsForm_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void btnMostOrdered_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT TOP 5 m.MEAL_NAME, SUM(od.QUANTITY) AS TotalOrdered
                                FROM ORDER_DETAILS od
                                JOIN MEAL m ON od.MEAL_NAME = m.MEAL_NAME
                                JOIN [ORDER] o ON od.ORDER_ID = o.ORDER_ID
                                WHERE o.STATUS = 'Paid'
                                GROUP BY m.MEAL_NAME
                                ORDER BY TotalOrdered DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                lblTitle.Text = "Top 5 Most Ordered Meals";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnNeverOrdered_Click(object sender, EventArgs e)
        {
            try
            {
                // Open connection if not open
                if (con.State != ConnectionState.Open)
                    con.Open();

                string query = @"
            SELECT m.MEAL_NAME, m.CATEGORY, m.PRICE
            FROM MEAL m
            WHERE NOT EXISTS (
                SELECT 1
                FROM ORDER_DETAILS od
                JOIN [ORDER] o ON od.ORDER_ID = o.ORDER_ID
                WHERE od.MEAL_NAME = m.MEAL_NAME
                  AND o.STATUS = 'Paid'
            )
            ORDER BY m.MEAL_NAME";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblTitle.Text = "Meals Never Ordered (Paid Orders Only)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }


        private void btnPopularMeals_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure connection is open
                if (con.State != ConnectionState.Open)
                    con.Open();

                string query = @"
            SELECT m.MEAL_NAME, SUM(od.QUANTITY) AS TotalOrdered
            FROM MEAL m
            JOIN ORDER_DETAILS od ON m.MEAL_NAME = od.MEAL_NAME
            JOIN [ORDER] o ON od.ORDER_ID = o.ORDER_ID
            WHERE o.ORDER_DATE >= DATEADD(month, -2, GETDATE())
              AND o.STATUS = 'Paid'
            GROUP BY m.MEAL_NAME
            HAVING SUM(od.QUANTITY) > 5
            ORDER BY TotalOrdered DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblTitle.Text = "Popular Meals (Ordered > 5 times in 2 months)";
                }
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