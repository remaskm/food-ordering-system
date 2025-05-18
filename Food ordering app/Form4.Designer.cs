namespace Food_ordering_app
{
    partial class admin_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Cedit = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.btnCustomerAnalytics = new System.Windows.Forms.Button();
            this.btnMealAnalytics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 487);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cedit
            // 
            this.Cedit.Location = new System.Drawing.Point(94, 91);
            this.Cedit.Margin = new System.Windows.Forms.Padding(4);
            this.Cedit.Name = "Cedit";
            this.Cedit.Size = new System.Drawing.Size(180, 28);
            this.Cedit.TabIndex = 1;
            this.Cedit.TabStop = false;
            this.Cedit.Text = "Edit Customers";
            this.Cedit.UseVisualStyleBackColor = true;
            this.Cedit.Click += new System.EventHandler(this.Cedit_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(94, 136);
            this.menu.Margin = new System.Windows.Forms.Padding(4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(180, 28);
            this.menu.TabIndex = 2;
            this.menu.Text = "View Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // btnCustomerAnalytics
            // 
            this.btnCustomerAnalytics.Location = new System.Drawing.Point(94, 236);
            this.btnCustomerAnalytics.Name = "btnCustomerAnalytics";
            this.btnCustomerAnalytics.Size = new System.Drawing.Size(180, 28);
            this.btnCustomerAnalytics.TabIndex = 3;
            this.btnCustomerAnalytics.Text = "Customer Analytics";
            this.btnCustomerAnalytics.UseVisualStyleBackColor = true;
            this.btnCustomerAnalytics.Click += new System.EventHandler(this.btnCustomerAnalytics_Click);
            // 
            // btnMealAnalytics
            // 
            this.btnMealAnalytics.Location = new System.Drawing.Point(94, 188);
            this.btnMealAnalytics.Name = "btnMealAnalytics";
            this.btnMealAnalytics.Size = new System.Drawing.Size(180, 27);
            this.btnMealAnalytics.TabIndex = 4;
            this.btnMealAnalytics.Text = "Meal Analytics";
            this.btnMealAnalytics.UseVisualStyleBackColor = true;
            this.btnMealAnalytics.Click += new System.EventHandler(this.btnMealAnalytics_Click);
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(374, 385);
            this.Controls.Add(this.btnMealAnalytics);
            this.Controls.Add(this.btnCustomerAnalytics);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.Cedit);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin_form";
            this.Text = "Admin Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cedit;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button btnCustomerAnalytics;
        private System.Windows.Forms.Button btnMealAnalytics;
    }
}