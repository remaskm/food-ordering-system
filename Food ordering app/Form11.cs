using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class BillForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");
        private readonly int orderId;
        private readonly int paymentId;

        public BillForm(int orderId, int paymentId)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.paymentId = paymentId;
            LoadReceiptData();
        }

        private void LoadReceiptData()
        {
            try
            {
                using (var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True"))
                {
                    con.Open();
                    LoadHeaderInfo(con);
                    LoadOrderItems(con);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading receipt: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHeaderInfo(SqlConnection con)
        {
            string query = @"
                SELECT 
                    o.ORDER_ID, 
                    FORMAT(o.ORDER_DATE, 'dd MMM yyyy HH:mm') AS ORDER_DATE,
                    p.PAYMENTID, 
                    p.AMOUNT,
                    FORMAT(p.PAYMENTDATE, 'dd MMM yyyy HH:mm') AS PAYMENTDATE,
                    p.METHOD,
                    u.USER_NAME
                FROM [ORDER] o
                JOIN PAYMENT p ON o.ORDER_ID = p.ORDER_ID
                JOIN [USER] u ON o.USER_ID = u.USER_ID
                WHERE o.ORDER_ID = @orderId AND p.PAYMENTID = @paymentId";

            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.Parameters.AddWithValue("@paymentId", paymentId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblOrderId.Text += $" {reader["ORDER_ID"]}";
                        lblPaymentId.Text += $" {reader["PAYMENTID"]}";
                        lblCustomer.Text += $" {reader["USER_NAME"]}";
                        lblTotalAmount.Text += $" {Convert.ToDecimal(reader["AMOUNT"]):C2}";
                        lblOrderDate.Text += $" {reader["ORDER_DATE"]}";
                        lblPaymentDate.Text += $" {reader["PAYMENTDATE"]}";
                        lblPaymentMethod.Text += $" {reader["METHOD"]}";
                    }
                }
            }
        }

        private void LoadOrderItems(SqlConnection con)
        {
            string query = @"
                SELECT 
                    m.MEAL_NAME AS Item,
                    od.QUANTITY AS Qty,
                    m.PRICE AS UnitPrice,
                    (m.PRICE * od.QUANTITY) AS Total
                FROM ORDER_DETAILS od
                JOIN MEAL m ON od.MEAL_NAME = m.MEAL_NAME
                WHERE od.ORDER_ID = @orderId";

            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@orderId", orderId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var itemPanel = new Panel
                        {
                            Width = itemsPanel.Width - 5,
                            Height = 25,
                            Margin = new Padding(0, 0, 0, 5)
                        };

                        var lblItem = new Label
                        {
                            Text = $"{reader["Item"]} x{reader["Qty"]}",
                            Font = new Font("Segoe UI", 9),
                            Dock = DockStyle.Left,
                            AutoSize = true
                        };

                        var lblPrice = new Label
                        {
                            Text = $"{Convert.ToDecimal(reader["Total"]):C2}",
                            Font = new Font("Segoe UI", 9),
                            Dock = DockStyle.Right,
                            AutoSize = true
                        };

                        itemPanel.Controls.Add(lblPrice);
                        itemPanel.Controls.Add(lblItem);
                        itemsPanel.Controls.Add(itemPanel);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();

            customer_form cform = new customer_form();
            cform.Show();
            this.Hide();
        }
    }
}