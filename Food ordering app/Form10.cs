using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class PaymentForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");
        private int currentOrderId;

        public PaymentForm(int orderId)
        {
            InitializeComponent();
            currentOrderId = orderId;
            SetupPaymentControls();
        }

        private void SetupPaymentControls()
        {
            // Configure amount display
            amountTextBox.ReadOnly = true;
            amountTextBox.Font = new Font("Microsoft Sans Serif", 10);

            // Configure date display
            dateTextBox.ReadOnly = true;
            dateTextBox.Font = new Font("Microsoft Sans Serif", 10);

            // Set up payment method dropdown
            paymentMethodComboBox.Items.AddRange(new string[] { "Cash", "Credit Card" });
            paymentMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                LoadPendingOrders();

                // Auto-select the order if one was passed to constructor
                if (currentOrderId > 0)
                {
                    foreach (DataRowView item in orderComboBox.Items)
                    {
                        if ((int)item["ORDER_ID"] == currentOrderId)
                        {
                            orderComboBox.SelectedItem = item;
                            LoadOrderDetails();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing payment form: " + ex.Message);
            }
        }

        private void LoadPendingOrders()
        {
            try
            {
                string query = "SELECT ORDER_ID FROM [ORDER] WHERE USER_ID = @userId AND STATUS = 'Pending'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                orderComboBox.DataSource = dt;
                orderComboBox.DisplayMember = "ORDER_ID";
                orderComboBox.ValueMember = "ORDER_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending orders: " + ex.Message);
            }
        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderComboBox.SelectedIndex != -1)
            {
                LoadOrderDetails();
            }
        }

        private void LoadOrderDetails()
        {
            try
            {
                int orderId = (int)orderComboBox.SelectedValue;

                // Calculate total amount
                string amountQuery = @"
                    SELECT SUM(m.Price * od.QUANTITY) 
                    FROM ORDER_DETAILS od
                    JOIN MEAL m ON od.MEAL_NAME = m.MEAL_NAME
                    WHERE od.ORDER_ID = @orderId";

                SqlCommand amountCmd = new SqlCommand(amountQuery, con);
                amountCmd.Parameters.AddWithValue("@orderId", orderId);
                decimal amount = (decimal)amountCmd.ExecuteScalar();

                // Update UI
                amountTextBox.Text = amount.ToString("C");
                dateTextBox.Text = DateTime.Now.ToShortDateString();
                paymentMethodComboBox.Enabled = true;
                confirmPaymentBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order details: " + ex.Message);
            }
        }

        private void confirmPaymentBtn_Click(object sender, EventArgs e)
        {
            if (orderComboBox.SelectedIndex == -1 || paymentMethodComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order and payment method");
                return;
            }

            try
            {
                int orderId = (int)orderComboBox.SelectedValue;
                string method = paymentMethodComboBox.SelectedItem.ToString();
                decimal amount = decimal.Parse(amountTextBox.Text, System.Globalization.NumberStyles.Currency);

                if (con.State != ConnectionState.Open)
                    con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Insert payment and get PaymentID
                        string paymentInsertQuery = @"
                    INSERT INTO PAYMENT (ORDER_ID, AMOUNT, METHOD, PAYMENTDATE)
                    OUTPUT INSERTED.PAYMENTID
                    VALUES (@orderId, @amount, @method, @date)";

                        SqlCommand paymentCmd = new SqlCommand(paymentInsertQuery, con, transaction);
                        paymentCmd.Parameters.AddWithValue("@orderId", orderId);
                        paymentCmd.Parameters.AddWithValue("@amount", amount);
                        paymentCmd.Parameters.AddWithValue("@method", method);
                        paymentCmd.Parameters.AddWithValue("@date", DateTime.Now);

                        int paymentId = (int)paymentCmd.ExecuteScalar();

                        // Update order status to 'Paid' and set PAYMENTID
                        string updateOrderQuery = @"
                    UPDATE [ORDER] 
                    SET STATUS = 'Paid', PAYMENTID = @paymentId 
                    WHERE ORDER_ID = @orderId";

                        SqlCommand updateCmd = new SqlCommand(updateOrderQuery, con, transaction);
                        updateCmd.Parameters.AddWithValue("@paymentId", paymentId);
                        updateCmd.Parameters.AddWithValue("@orderId", orderId);
                        updateCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK);

                        // Show bill form
                        BillForm billForm = new BillForm(orderId, paymentId);
                        billForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error processing payment: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message);
            }
        }


        private void returnBtn_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}