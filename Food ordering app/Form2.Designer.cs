namespace Food_ordering_app
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Id_box = new System.Windows.Forms.TextBox();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Phone_box = new System.Windows.Forms.TextBox();
            this.sign_up = new System.Windows.Forms.Button();
            this.check_role = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "What are you?";
            // 
            // Id_box
            // 
            this.Id_box.Location = new System.Drawing.Point(262, 58);
            this.Id_box.Margin = new System.Windows.Forms.Padding(4);
            this.Id_box.Name = "Id_box";
            this.Id_box.Size = new System.Drawing.Size(132, 22);
            this.Id_box.TabIndex = 4;
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(262, 115);
            this.Name_box.Margin = new System.Windows.Forms.Padding(4);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(132, 22);
            this.Name_box.TabIndex = 5;
            // 
            // Phone_box
            // 
            this.Phone_box.Location = new System.Drawing.Point(262, 159);
            this.Phone_box.Margin = new System.Windows.Forms.Padding(4);
            this.Phone_box.Name = "Phone_box";
            this.Phone_box.Size = new System.Drawing.Size(132, 22);
            this.Phone_box.TabIndex = 6;
            // 
            // sign_up
            // 
            this.sign_up.Location = new System.Drawing.Point(170, 328);
            this.sign_up.Margin = new System.Windows.Forms.Padding(4);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(224, 68);
            this.sign_up.TabIndex = 8;
            this.sign_up.Text = "Create Account";
            this.sign_up.UseVisualStyleBackColor = true;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // check_role
            // 
            this.check_role.FormattingEnabled = true;
            this.check_role.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.check_role.Location = new System.Drawing.Point(262, 215);
            this.check_role.Margin = new System.Windows.Forms.Padding(4);
            this.check_role.Name = "check_role";
            this.check_role.Size = new System.Drawing.Size(132, 24);
            this.check_role.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 71);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back to sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(571, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_role);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.Phone_box);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.Id_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Id_box;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.TextBox Phone_box;
        private System.Windows.Forms.Button sign_up;
        private System.Windows.Forms.ComboBox check_role;
        private System.Windows.Forms.Button button1;
    }
}