namespace Food_ordering_app
{
    partial class FeedbackForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.addFeedbackLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            this.ratingNumeric = new System.Windows.Forms.NumericUpDown();
            this.addFeedbackBtn = new System.Windows.Forms.Button();
            this.existingFeedbackLabel = new System.Windows.Forms.Label();
            this.existingFeedbackComboBox = new System.Windows.Forms.ComboBox();
            this.modifyFeedbackBtn = new System.Windows.Forms.Button();
            this.deleteFeedbackBtn = new System.Windows.Forms.Button();
            this.feedbackDataGrid = new System.Windows.Forms.DataGridView();
            this.editableFeedbackGrid = new System.Windows.Forms.DataGridView();
            this.updateFeedbackBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editableFeedbackGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addFeedbackLabel
            // 
            this.addFeedbackLabel.AutoSize = true;
            this.addFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFeedbackLabel.Location = new System.Drawing.Point(27, 25);
            this.addFeedbackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addFeedbackLabel.Name = "addFeedbackLabel";
            this.addFeedbackLabel.Size = new System.Drawing.Size(152, 25);
            this.addFeedbackLabel.TabIndex = 0;
            this.addFeedbackLabel.Text = "Add Feedback";
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(27, 74);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(40, 16);
            this.mealLabel.TabIndex = 1;
            this.mealLabel.Text = "Meal:";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(27, 111);
            this.feedbackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(72, 16);
            this.feedbackLabel.TabIndex = 2;
            this.feedbackLabel.Text = "Feedback:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(29, 207);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(49, 16);
            this.ratingLabel.TabIndex = 3;
            this.ratingLabel.Text = "Rating:";
            // 
            // mealComboBox
            // 
            this.mealComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Location = new System.Drawing.Point(133, 74);
            this.mealComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(265, 24);
            this.mealComboBox.TabIndex = 4;
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(133, 111);
            this.feedbackTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.feedbackTextBox.Multiline = true;
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(427, 73);
            this.feedbackTextBox.TabIndex = 5;
            // 
            // ratingNumeric
            // 
            this.ratingNumeric.Location = new System.Drawing.Point(133, 205);
            this.ratingNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.ratingNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratingNumeric.Name = "ratingNumeric";
            this.ratingNumeric.Size = new System.Drawing.Size(67, 22);
            this.ratingNumeric.TabIndex = 6;
            this.ratingNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // addFeedbackBtn
            // 
            this.addFeedbackBtn.Location = new System.Drawing.Point(427, 197);
            this.addFeedbackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addFeedbackBtn.Name = "addFeedbackBtn";
            this.addFeedbackBtn.Size = new System.Drawing.Size(133, 37);
            this.addFeedbackBtn.TabIndex = 7;
            this.addFeedbackBtn.Text = "Add Feedback";
            this.addFeedbackBtn.UseVisualStyleBackColor = true;
            this.addFeedbackBtn.Click += new System.EventHandler(this.addFeedbackBtn_Click);
            // 
            // existingFeedbackLabel
            // 
            this.existingFeedbackLabel.AutoSize = true;
            this.existingFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingFeedbackLabel.Location = new System.Drawing.Point(30, 252);
            this.existingFeedbackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.existingFeedbackLabel.Name = "existingFeedbackLabel";
            this.existingFeedbackLabel.Size = new System.Drawing.Size(169, 25);
            this.existingFeedbackLabel.TabIndex = 8;
            this.existingFeedbackLabel.Text = "Your Feedbacks";
            this.existingFeedbackLabel.Visible = false;
            // 
            // existingFeedbackComboBox
            // 
            this.existingFeedbackComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingFeedbackComboBox.FormattingEnabled = true;
            this.existingFeedbackComboBox.Location = new System.Drawing.Point(30, 288);
            this.existingFeedbackComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.existingFeedbackComboBox.Name = "existingFeedbackComboBox";
            this.existingFeedbackComboBox.Size = new System.Drawing.Size(265, 24);
            this.existingFeedbackComboBox.TabIndex = 9;
            this.existingFeedbackComboBox.Visible = false;
            // 
            // modifyFeedbackBtn
            // 
            this.modifyFeedbackBtn.Location = new System.Drawing.Point(323, 288);
            this.modifyFeedbackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifyFeedbackBtn.Name = "modifyFeedbackBtn";
            this.modifyFeedbackBtn.Size = new System.Drawing.Size(133, 31);
            this.modifyFeedbackBtn.TabIndex = 10;
            this.modifyFeedbackBtn.Text = "Modify Feedback";
            this.modifyFeedbackBtn.UseVisualStyleBackColor = true;
            this.modifyFeedbackBtn.Visible = false;
            this.modifyFeedbackBtn.Click += new System.EventHandler(this.modifyFeedbackBtn_Click);
            // 
            // deleteFeedbackBtn
            // 
            this.deleteFeedbackBtn.Location = new System.Drawing.Point(483, 288);
            this.deleteFeedbackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteFeedbackBtn.Name = "deleteFeedbackBtn";
            this.deleteFeedbackBtn.Size = new System.Drawing.Size(133, 31);
            this.deleteFeedbackBtn.TabIndex = 11;
            this.deleteFeedbackBtn.Text = "Delete Feedback";
            this.deleteFeedbackBtn.UseVisualStyleBackColor = true;
            this.deleteFeedbackBtn.Visible = false;
            this.deleteFeedbackBtn.Click += new System.EventHandler(this.deleteFeedbackBtn_Click);
            // 
            // feedbackDataGrid
            // 
            this.feedbackDataGrid.AllowUserToAddRows = false;
            this.feedbackDataGrid.AllowUserToDeleteRows = false;
            this.feedbackDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.feedbackDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackDataGrid.Location = new System.Drawing.Point(30, 338);
            this.feedbackDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.feedbackDataGrid.Name = "feedbackDataGrid";
            this.feedbackDataGrid.ReadOnly = true;
            this.feedbackDataGrid.RowHeadersWidth = 51;
            this.feedbackDataGrid.Size = new System.Drawing.Size(667, 185);
            this.feedbackDataGrid.TabIndex = 12;
            // 
            // editableFeedbackGrid
            // 
            this.editableFeedbackGrid.AllowUserToAddRows = false;
            this.editableFeedbackGrid.AllowUserToDeleteRows = false;
            this.editableFeedbackGrid.BackgroundColor = System.Drawing.Color.White;
            this.editableFeedbackGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editableFeedbackGrid.Location = new System.Drawing.Point(30, 547);
            this.editableFeedbackGrid.Margin = new System.Windows.Forms.Padding(4);
            this.editableFeedbackGrid.Name = "editableFeedbackGrid";
            this.editableFeedbackGrid.RowHeadersWidth = 51;
            this.editableFeedbackGrid.Size = new System.Drawing.Size(667, 123);
            this.editableFeedbackGrid.TabIndex = 13;
            this.editableFeedbackGrid.Visible = false;
            // 
            // updateFeedbackBtn
            // 
            this.updateFeedbackBtn.Location = new System.Drawing.Point(563, 682);
            this.updateFeedbackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateFeedbackBtn.Name = "updateFeedbackBtn";
            this.updateFeedbackBtn.Size = new System.Drawing.Size(133, 37);
            this.updateFeedbackBtn.TabIndex = 14;
            this.updateFeedbackBtn.Text = "Update Feedback";
            this.updateFeedbackBtn.UseVisualStyleBackColor = true;
            this.updateFeedbackBtn.Visible = false;
            this.updateFeedbackBtn.Click += new System.EventHandler(this.updateFeedbackBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(30, 682);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(133, 37);
            this.returnBtn.TabIndex = 15;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(733, 738);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.updateFeedbackBtn);
            this.Controls.Add(this.editableFeedbackGrid);
            this.Controls.Add(this.feedbackDataGrid);
            this.Controls.Add(this.deleteFeedbackBtn);
            this.Controls.Add(this.modifyFeedbackBtn);
            this.Controls.Add(this.existingFeedbackComboBox);
            this.Controls.Add(this.existingFeedbackLabel);
            this.Controls.Add(this.addFeedbackBtn);
            this.Controls.Add(this.ratingNumeric);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.addFeedbackLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeedbackForm";
            this.Text = "Customer Feedback";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editableFeedbackGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addFeedbackLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ComboBox mealComboBox;
        private System.Windows.Forms.TextBox feedbackTextBox;
        private System.Windows.Forms.NumericUpDown ratingNumeric;
        private System.Windows.Forms.Button addFeedbackBtn;
        private System.Windows.Forms.Label existingFeedbackLabel;
        private System.Windows.Forms.ComboBox existingFeedbackComboBox;
        private System.Windows.Forms.Button modifyFeedbackBtn;
        private System.Windows.Forms.Button deleteFeedbackBtn;
        private System.Windows.Forms.DataGridView feedbackDataGrid;
        private System.Windows.Forms.DataGridView editableFeedbackGrid;
        private System.Windows.Forms.Button updateFeedbackBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}
