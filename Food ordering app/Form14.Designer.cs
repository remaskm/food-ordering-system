namespace Food_ordering_app
{
    partial class MealAnalyticsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostOrdered = new System.Windows.Forms.Button();
            this.btnNeverOrdered = new System.Windows.Forms.Button();
            this.btnPopularMeals = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMostOrdered
            // 
            this.btnMostOrdered.BackColor = System.Drawing.Color.White;
            this.btnMostOrdered.Location = new System.Drawing.Point(90, 29);
            this.btnMostOrdered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostOrdered.Name = "btnMostOrdered";
            this.btnMostOrdered.Size = new System.Drawing.Size(200, 37);
            this.btnMostOrdered.TabIndex = 1;
            this.btnMostOrdered.Text = "Most Ordered Meals";
            this.btnMostOrdered.UseVisualStyleBackColor = false;
            this.btnMostOrdered.Click += new System.EventHandler(this.btnMostOrdered_Click);
            // 
            // btnNeverOrdered
            // 
            this.btnNeverOrdered.BackColor = System.Drawing.Color.White;
            this.btnNeverOrdered.Location = new System.Drawing.Point(329, 29);
            this.btnNeverOrdered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNeverOrdered.Name = "btnNeverOrdered";
            this.btnNeverOrdered.Size = new System.Drawing.Size(200, 37);
            this.btnNeverOrdered.TabIndex = 2;
            this.btnNeverOrdered.Text = "Never Ordered Meals";
            this.btnNeverOrdered.UseVisualStyleBackColor = false;
            this.btnNeverOrdered.Click += new System.EventHandler(this.btnNeverOrdered_Click);
            // 
            // btnPopularMeals
            // 
            this.btnPopularMeals.BackColor = System.Drawing.Color.White;
            this.btnPopularMeals.Location = new System.Drawing.Point(561, 29);
            this.btnPopularMeals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPopularMeals.Name = "btnPopularMeals";
            this.btnPopularMeals.Size = new System.Drawing.Size(200, 37);
            this.btnPopularMeals.TabIndex = 3;
            this.btnPopularMeals.Text = "Popular Meals";
            this.btnPopularMeals.UseVisualStyleBackColor = false;
            this.btnPopularMeals.Click += new System.EventHandler(this.btnPopularMeals_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(27, 455);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 20);
            this.lblTitle.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(693, 455);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MealAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(853, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPopularMeals);
            this.Controls.Add(this.btnNeverOrdered);
            this.Controls.Add(this.btnMostOrdered);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MealAnalyticsForm";
            this.Text = "Meal Analytics";
            this.Load += new System.EventHandler(this.MealAnalyticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostOrdered;
        private System.Windows.Forms.Button btnNeverOrdered;
        private System.Windows.Forms.Button btnPopularMeals;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}