namespace Food_ordering_app
{
    partial class CustomerAnalyticsForm
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
            this.btnCustomerSpending = new System.Windows.Forms.Button();
            this.btnTopCustomer = new System.Windows.Forms.Button();
            this.btnOrderCounts = new System.Windows.Forms.Button();
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
            // btnCustomerSpending
            // 
            this.btnCustomerSpending.BackColor = System.Drawing.Color.White;
            this.btnCustomerSpending.Location = new System.Drawing.Point(56, 29);
            this.btnCustomerSpending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomerSpending.Name = "btnCustomerSpending";
            this.btnCustomerSpending.Size = new System.Drawing.Size(240, 37);
            this.btnCustomerSpending.TabIndex = 1;
            this.btnCustomerSpending.Text = "Customer Spending";
            this.btnCustomerSpending.UseVisualStyleBackColor = false;
            this.btnCustomerSpending.Click += new System.EventHandler(this.btnCustomerSpending_Click);
            // 
            // btnTopCustomer
            // 
            this.btnTopCustomer.BackColor = System.Drawing.Color.White;
            this.btnTopCustomer.Location = new System.Drawing.Point(309, 29);
            this.btnTopCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTopCustomer.Name = "btnTopCustomer";
            this.btnTopCustomer.Size = new System.Drawing.Size(240, 37);
            this.btnTopCustomer.TabIndex = 2;
            this.btnTopCustomer.Text = "Top Customer (Month)";
            this.btnTopCustomer.UseVisualStyleBackColor = false;
            this.btnTopCustomer.Click += new System.EventHandler(this.btnTopCustomer_Click);
            // 
            // btnOrderCounts
            // 
            this.btnOrderCounts.BackColor = System.Drawing.Color.White;
            this.btnOrderCounts.Location = new System.Drawing.Point(562, 29);
            this.btnOrderCounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderCounts.Name = "btnOrderCounts";
            this.btnOrderCounts.Size = new System.Drawing.Size(240, 37);
            this.btnOrderCounts.TabIndex = 3;
            this.btnOrderCounts.Text = "Order Counts";
            this.btnOrderCounts.UseVisualStyleBackColor = false;
            this.btnOrderCounts.Click += new System.EventHandler(this.btnOrderCounts_Click);
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
            // CustomerAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(853, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOrderCounts);
            this.Controls.Add(this.btnTopCustomer);
            this.Controls.Add(this.btnCustomerSpending);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerAnalyticsForm";
            this.Text = "Customer Analytics";
            this.Load += new System.EventHandler(this.CustomerAnalyticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCustomerSpending;
        private System.Windows.Forms.Button btnTopCustomer;
        private System.Windows.Forms.Button btnOrderCounts;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}