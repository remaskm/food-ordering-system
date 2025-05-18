using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Food_ordering_app
{
    public partial class FeedbackForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FoodOrderingSystem;Integrated Security=True");
        private DataTable feedbackTable = new DataTable();

        public FeedbackForm()
        {
            InitializeComponent();
            InitializeFeedbackTable();
        }

        private void InitializeFeedbackTable()
        {
            feedbackTable.Columns.Add("Comment", typeof(string));
            feedbackTable.Columns.Add("Rating", typeof(int));
            feedbackTable.Columns.Add("FeedbackDate", typeof(DateTime));

            feedbackDataGrid.DataSource = feedbackTable;
            feedbackDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            feedbackDataGrid.ReadOnly = true;
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                LoadMealsComboBox();
                CheckExistingFeedback();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void LoadMealsComboBox()
        {
            try
            {
                // Load only meals that the customer has ordered and paid for
                string query = @"SELECT DISTINCT m.MEAL_NAME 
                                FROM ORDER_DETAILS od
                                JOIN [ORDER] o ON od.ORDER_ID = o.ORDER_ID
                                JOIN MEAL m ON od.MEAL_NAME = m.MEAL_NAME
                                WHERE o.USER_ID = @userId AND o.STATUS = 'Paid'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                mealComboBox.DataSource = dt;
                mealComboBox.DisplayMember = "MEAL_NAME";
                mealComboBox.ValueMember = "MEAL_NAME";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meals: " + ex.Message);
            }
        }

        private void CheckExistingFeedback()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM FEEDBACK WHERE USER_ID = @userId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                int feedbackCount = (int)cmd.ExecuteScalar();

                if (feedbackCount > 0)
                {
                    // Show existing feedback section
                    existingFeedbackLabel.Visible = true;
                    existingFeedbackComboBox.Visible = true;
                    modifyFeedbackBtn.Visible = true;
                    deleteFeedbackBtn.Visible = true;

                    // Load existing feedback into combo box
                    LoadExistingFeedback();
                }
                else
                {
                    // Hide existing feedback section
                    existingFeedbackLabel.Visible = false;
                    existingFeedbackComboBox.Visible = false;
                    modifyFeedbackBtn.Visible = false;
                    deleteFeedbackBtn.Visible = false;
                    editableFeedbackGrid.Visible = false;
                    updateFeedbackBtn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for existing feedback: " + ex.Message);
            }
        }

        private void LoadExistingFeedback()
        {
            try
            {
                string query = @"SELECT f.FEEDBACKID, m.MEAL_NAME, f.COMMENT 
                                FROM FEEDBACK f
                                JOIN MEAL m ON f.MEAL_NAME = m.MEAL_NAME
                                WHERE f.USER_ID = @userId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                existingFeedbackComboBox.DataSource = dt;
                existingFeedbackComboBox.DisplayMember = "MEAL_NAME";
                existingFeedbackComboBox.ValueMember = "FEEDBACKID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading existing feedback: " + ex.Message);
            }
        }

        private void addFeedbackBtn_Click(object sender, EventArgs e)
        {
            if (mealComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a meal");
                return;
            }

            if (string.IsNullOrWhiteSpace(feedbackTextBox.Text))
            {
                MessageBox.Show("Please enter your feedback");
                return;
            }

            try
            {
                // Insert feedback into database
                string query = @"INSERT INTO FEEDBACK (USER_ID, MEAL_NAME, COMMENT, RATING, FEEDBACKDATE)
                                 VALUES (@userId, @mealName, @comment, @rating, @date)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                cmd.Parameters.AddWithValue("@mealName", mealComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@comment", feedbackTextBox.Text);
                cmd.Parameters.AddWithValue("@rating", ratingNumeric.Value);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Feedback added successfully!");

                    // Refresh the feedback display
                    LoadAllFeedbacks();
                    CheckExistingFeedback();

                    // Clear input fields
                    feedbackTextBox.Clear();
                    ratingNumeric.Value = 3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding feedback: " + ex.Message);
            }
        }

        private void LoadAllFeedbacks()
        {
            try
            {
                string query = @"SELECT m.MEAL_NAME, f.COMMENT, f.RATING, f.FEEDBACKDATE
                         FROM FEEDBACK f
                         JOIN MEAL m ON f.MEAL_NAME = m.MEAL_NAME";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                feedbackTable.Clear(); // Clear old data
                da.Fill(feedbackTable); // Fill with all feedbacks
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all feedbacks: " + ex.Message);
            }
        }


        private void modifyFeedbackBtn_Click(object sender, EventArgs e)
        {
            if (existingFeedbackComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select feedback to modify");
                return;
            }

            try
            {
                // Load selected feedback into editable grid
                string query = @"SELECT m.MEAL_NAME AS Meal, f.COMMENT AS Comment, f.RATING
                                FROM FEEDBACK f
                                JOIN MEAL m ON f.MEAL_NAME = m.MEAL_NAME
                                WHERE f.FEEDBACKID = @feedbackId AND f.USER_ID = @userId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@feedbackId", existingFeedbackComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                editableFeedbackGrid.DataSource = dt;
                editableFeedbackGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                editableFeedbackGrid.ReadOnly = false; // Make it editable
                editableFeedbackGrid.Visible = true;
                updateFeedbackBtn.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback for editing: " + ex.Message);
            }
        }

        private void updateFeedbackBtn_Click(object sender, EventArgs e)
        {
            if (editableFeedbackGrid.Rows.Count == 0)
            {
                MessageBox.Show("No feedback to update");
                return;
            }

            try
            {
                DataRowView row = (DataRowView)editableFeedbackGrid.Rows[0].DataBoundItem;
                string comment = row["Comment"].ToString();
                int rating = Convert.ToInt32(row["Rating"]);

                string query = @"UPDATE FEEDBACK 
                                SET COMMENT = @comment, RATING = @rating
                                WHERE FEEDBACKID = @feedbackId AND USER_ID = @userId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@feedbackId", existingFeedbackComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Feedback updated successfully!");
                    editableFeedbackGrid.Visible = false;
                    updateFeedbackBtn.Visible = false;

                    // Refresh the feedback display
                    LoadAllFeedbacks();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating feedback: " + ex.Message);
            }
        }

        private void deleteFeedbackBtn_Click(object sender, EventArgs e)
        {
            if (existingFeedbackComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select feedback to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this feedback?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM FEEDBACK WHERE FEEDBACKID = @feedbackId AND USER_ID = @userId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@feedbackId", existingFeedbackComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Feedback deleted successfully!");

                        // Refresh the form
                        CheckExistingFeedback();
                        LoadAllFeedbacks();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting feedback: " + ex.Message);
                }
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            customer_form cform = new customer_form();
            cform.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void feedbackDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}