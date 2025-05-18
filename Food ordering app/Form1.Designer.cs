namespace Food_ordering_app
{
    partial class Form1
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
            this.sign_up = new System.Windows.Forms.Button();
            this.sign_in = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sign_up
            // 
            this.sign_up.Location = new System.Drawing.Point(593, 428);
            this.sign_up.Margin = new System.Windows.Forms.Padding(4);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(151, 55);
            this.sign_up.TabIndex = 0;
            this.sign_up.Text = "Sign up";
            this.sign_up.UseVisualStyleBackColor = true;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // sign_in
            // 
            this.sign_in.Location = new System.Drawing.Point(307, 288);
            this.sign_in.Margin = new System.Windows.Forms.Padding(4);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(151, 63);
            this.sign_in.TabIndex = 1;
            this.sign_in.Text = "Sign In";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(230, 208);
            this.id_box.Margin = new System.Windows.Forms.Padding(4);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(348, 22);
            this.id_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "User ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Don\'t have an account?";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(66, 428);
            this.test.Margin = new System.Windows.Forms.Padding(4);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 28);
            this.test.TabIndex = 7;
            this.test.Text = "View Menu";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(781, 510);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.sign_up);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Start form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sign_up;
        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button test;
    }
}

