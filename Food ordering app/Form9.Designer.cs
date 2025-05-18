namespace Food_ordering_app
{
    partial class OrderForm
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
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToOrderBtn = new System.Windows.Forms.Button();
            this.confirmOrderBtn = new System.Windows.Forms.Button();
            this.cancelOrderComboBox = new System.Windows.Forms.ComboBox();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.proceedToPaymentBtn = new System.Windows.Forms.Button();
            this.orderDetailsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mealComboBox
            // 
            this.mealComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Location = new System.Drawing.Point(40, 40);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(200, 24);
            this.mealComboBox.TabIndex = 0;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(260, 40);
            this.quantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(60, 22);
            this.quantityUpDown.TabIndex = 1;
            this.quantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addToOrderBtn
            // 
            this.addToOrderBtn.Location = new System.Drawing.Point(340, 40);
            this.addToOrderBtn.Name = "addToOrderBtn";
            this.addToOrderBtn.Size = new System.Drawing.Size(120, 25);
            this.addToOrderBtn.TabIndex = 2;
            this.addToOrderBtn.Text = "Add to Order";
            this.addToOrderBtn.UseVisualStyleBackColor = true;
            this.addToOrderBtn.Click += new System.EventHandler(this.addToOrderBtn_Click);
            // 
            // confirmOrderBtn
            // 
            this.confirmOrderBtn.Location = new System.Drawing.Point(340, 75);
            this.confirmOrderBtn.Name = "confirmOrderBtn";
            this.confirmOrderBtn.Size = new System.Drawing.Size(120, 25);
            this.confirmOrderBtn.TabIndex = 3;
            this.confirmOrderBtn.Text = "Confirm Order";
            this.confirmOrderBtn.UseVisualStyleBackColor = true;
            this.confirmOrderBtn.Visible = false;
            this.confirmOrderBtn.Click += new System.EventHandler(this.confirmOrderBtn_Click);
            // 
            // cancelOrderComboBox
            // 
            this.cancelOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cancelOrderComboBox.FormattingEnabled = true;
            this.cancelOrderComboBox.Location = new System.Drawing.Point(40, 150);
            this.cancelOrderComboBox.Name = "cancelOrderComboBox";
            this.cancelOrderComboBox.Size = new System.Drawing.Size(200, 24);
            this.cancelOrderComboBox.TabIndex = 4;
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.Location = new System.Drawing.Point(260, 150);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(120, 25);
            this.cancelOrderBtn.TabIndex = 5;
            this.cancelOrderBtn.Text = "Cancel Order";
            this.cancelOrderBtn.UseVisualStyleBackColor = true;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(40, 300);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(100, 30);
            this.returnBtn.TabIndex = 6;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // proceedToPaymentBtn
            // 
            this.proceedToPaymentBtn.Location = new System.Drawing.Point(160, 300);
            this.proceedToPaymentBtn.Name = "proceedToPaymentBtn";
            this.proceedToPaymentBtn.Size = new System.Drawing.Size(150, 30);
            this.proceedToPaymentBtn.TabIndex = 7;
            this.proceedToPaymentBtn.Text = "Proceed to Payment";
            this.proceedToPaymentBtn.UseVisualStyleBackColor = true;
            this.proceedToPaymentBtn.Visible = false;
            this.proceedToPaymentBtn.Click += new System.EventHandler(this.proceedToPaymentBtn_Click);
            // 
            // orderDetailsGrid
            // 
            this.orderDetailsGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsGrid.Location = new System.Drawing.Point(40, 125);
            this.orderDetailsGrid.Name = "orderDetailsGrid";
            this.orderDetailsGrid.ReadOnly = true;
            this.orderDetailsGrid.RowHeadersWidth = 51;
            this.orderDetailsGrid.Size = new System.Drawing.Size(420, 150);
            this.orderDetailsGrid.TabIndex = 8;
            this.orderDetailsGrid.Visible = false;
            // 
            // OrderForm
            // 
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.orderDetailsGrid);
            this.Controls.Add(this.proceedToPaymentBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.cancelOrderComboBox);
            this.Controls.Add(this.confirmOrderBtn);
            this.Controls.Add(this.addToOrderBtn);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.mealComboBox);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mealComboBox;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Button addToOrderBtn;
        private System.Windows.Forms.Button confirmOrderBtn;
        private System.Windows.Forms.ComboBox cancelOrderComboBox;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button proceedToPaymentBtn;
        private System.Windows.Forms.DataGridView orderDetailsGrid;
    }
}