namespace Food_ordering_app
{
    partial class customer_form
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
            this.logOutBtn = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.Meal = new System.Windows.Forms.Button();
            this.orderNowBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(377, 202);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(180, 28);
            this.logOutBtn.TabIndex = 0;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(377, 141);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(180, 28);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit Profile";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(138, 78);
            this.menu.Margin = new System.Windows.Forms.Padding(4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(180, 28);
            this.menu.TabIndex = 3;
            this.menu.Text = "View Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Meal
            // 
            this.Meal.BackColor = System.Drawing.Color.White;
            this.Meal.Location = new System.Drawing.Point(138, 141);
            this.Meal.Margin = new System.Windows.Forms.Padding(4);
            this.Meal.Name = "Meal";
            this.Meal.Size = new System.Drawing.Size(180, 28);
            this.Meal.TabIndex = 4;
            this.Meal.Text = "Search for Meal";
            this.Meal.UseVisualStyleBackColor = false;
            this.Meal.Click += new System.EventHandler(this.button2_Click);
            // 
            // orderNowBtn
            // 
            this.orderNowBtn.BackColor = System.Drawing.Color.White;
            this.orderNowBtn.Location = new System.Drawing.Point(377, 78);
            this.orderNowBtn.Name = "orderNowBtn";
            this.orderNowBtn.Size = new System.Drawing.Size(180, 28);
            this.orderNowBtn.TabIndex = 0;
            this.orderNowBtn.Text = "Order Now";
            this.orderNowBtn.UseVisualStyleBackColor = false;
            this.orderNowBtn.Click += new System.EventHandler(this.orderNowBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.White;
            this.feedbackBtn.Location = new System.Drawing.Point(138, 202);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(180, 28);
            this.feedbackBtn.TabIndex = 5;
            this.feedbackBtn.Text = "Give Feedback";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(681, 346);
            this.Controls.Add(this.feedbackBtn);
            this.Controls.Add(this.orderNowBtn);
            this.Controls.Add(this.Meal);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.logOutBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "customer_form";
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.customer_form_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button Meal;
        private System.Windows.Forms.Button orderNowBtn;
        private System.Windows.Forms.Button feedbackBtn;
    }
}