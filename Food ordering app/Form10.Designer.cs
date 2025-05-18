namespace Food_ordering_app
{
    partial class PaymentForm
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

        private void InitializeComponent()
        {
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.confirmPaymentBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(50, 50);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(57, 16);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "Order ID";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(50, 100);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(115, 16);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount to be paid";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(50, 150);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(122, 16);
            this.methodLabel.TabIndex = 2;
            this.methodLabel.Text = "Method of Payment";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(50, 200);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(92, 16);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Payment Date";
            // 
            // orderComboBox
            // 
            this.orderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Location = new System.Drawing.Point(200, 50);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(200, 24);
            this.orderComboBox.TabIndex = 4;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(200, 100);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 22);
            this.amountTextBox.TabIndex = 5;
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodComboBox.Enabled = false;
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Location = new System.Drawing.Point(200, 150);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(200, 24);
            this.paymentMethodComboBox.TabIndex = 6;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(200, 200);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(200, 22);
            this.dateTextBox.TabIndex = 7;
            // 
            // confirmPaymentBtn
            // 
            this.confirmPaymentBtn.Enabled = false;
            this.confirmPaymentBtn.Location = new System.Drawing.Point(300, 250);
            this.confirmPaymentBtn.Name = "confirmPaymentBtn";
            this.confirmPaymentBtn.Size = new System.Drawing.Size(150, 30);
            this.confirmPaymentBtn.TabIndex = 8;
            this.confirmPaymentBtn.Text = "Confirm Payment";
            this.confirmPaymentBtn.UseVisualStyleBackColor = true;
            this.confirmPaymentBtn.Click += new System.EventHandler(this.confirmPaymentBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(12, 308);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(100, 30);
            this.returnBtn.TabIndex = 9;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.confirmPaymentBtn);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.paymentMethodComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button confirmPaymentBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}