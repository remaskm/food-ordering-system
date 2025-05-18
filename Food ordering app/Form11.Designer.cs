namespace Food_ordering_app
{
    partial class BillForm
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
            this.lblReceiptTitle = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblItemsTitle = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReceiptTitle
            // 
            this.lblReceiptTitle.AutoSize = true;
            this.lblReceiptTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblReceiptTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblReceiptTitle.Location = new System.Drawing.Point(89, 19);
            this.lblReceiptTitle.Name = "lblReceiptTitle";
            this.lblReceiptTitle.Size = new System.Drawing.Size(219, 37);
            this.lblReceiptTitle.TabIndex = 0;
            this.lblReceiptTitle.Text = "ORDER RECEIPT";
            this.lblReceiptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderId.Location = new System.Drawing.Point(50, 70);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(85, 23);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "Order ID: ";
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaymentId.Location = new System.Drawing.Point(50, 100);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(107, 23);
            this.lblPaymentId.TabIndex = 2;
            this.lblPaymentId.Text = "Payment ID: ";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(50, 130);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(93, 23);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer: ";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalAmount.Location = new System.Drawing.Point(50, 160);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(122, 23);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "Total Amount: ";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderDate.Location = new System.Drawing.Point(50, 190);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(104, 23);
            this.lblOrderDate.TabIndex = 5;
            this.lblOrderDate.Text = "Order Date: ";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaymentDate.Location = new System.Drawing.Point(50, 220);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(126, 23);
            this.lblPaymentDate.TabIndex = 6;
            this.lblPaymentDate.Text = "Payment Date: ";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaymentMethod.Location = new System.Drawing.Point(50, 250);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(150, 23);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "Payment Method: ";
            // 
            // lblItemsTitle
            // 
            this.lblItemsTitle.AutoSize = true;
            this.lblItemsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblItemsTitle.ForeColor = System.Drawing.Color.SlateGray;
            this.lblItemsTitle.Location = new System.Drawing.Point(50, 280);
            this.lblItemsTitle.Name = "lblItemsTitle";
            this.lblItemsTitle.Size = new System.Drawing.Size(135, 25);
            this.lblItemsTitle.TabIndex = 8;
            this.lblItemsTitle.Text = "ORDER ITEMS";
            // 
            // itemsPanel
            // 
            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.BackColor = System.Drawing.Color.White;
            this.itemsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemsPanel.Location = new System.Drawing.Point(50, 310);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(300, 100);
            this.itemsPanel.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SlateGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(150, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BillForm
            // 
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.lblReceiptTitle);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblPaymentId);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblItemsTitle);
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceiptTitle;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblItemsTitle;
        private System.Windows.Forms.FlowLayoutPanel itemsPanel;
        private System.Windows.Forms.Button btnClose;
    }
}