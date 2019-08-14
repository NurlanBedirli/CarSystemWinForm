namespace CarLogin
{
    partial class UserSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignIn));
            this.label1 = new System.Windows.Forms.Label();
            this.text_sign_email = new System.Windows.Forms.TextBox();
            this.text_sign_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text_errorPassword = new System.Windows.Forms.Label();
            this.text_errorEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(149, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // text_sign_email
            // 
            this.text_sign_email.BackColor = System.Drawing.Color.Black;
            this.text_sign_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sign_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_sign_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.text_sign_email.ForeColor = System.Drawing.Color.Aqua;
            this.text_sign_email.Location = new System.Drawing.Point(234, 130);
            this.text_sign_email.Multiline = true;
            this.text_sign_email.Name = "text_sign_email";
            this.text_sign_email.Size = new System.Drawing.Size(172, 28);
            this.text_sign_email.TabIndex = 1;
            // 
            // text_sign_password
            // 
            this.text_sign_password.BackColor = System.Drawing.Color.Black;
            this.text_sign_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sign_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.text_sign_password.ForeColor = System.Drawing.Color.Aqua;
            this.text_sign_password.Location = new System.Drawing.Point(234, 204);
            this.text_sign_password.Multiline = true;
            this.text_sign_password.Name = "text_sign_password";
            this.text_sign_password.Size = new System.Drawing.Size(172, 28);
            this.text_sign_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(149, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(259, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(259, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_errorPassword
            // 
            this.text_errorPassword.AutoSize = true;
            this.text_errorPassword.BackColor = System.Drawing.SystemColors.ControlText;
            this.text_errorPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_errorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.text_errorPassword.ForeColor = System.Drawing.Color.Crimson;
            this.text_errorPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.text_errorPassword.Location = new System.Drawing.Point(433, 206);
            this.text_errorPassword.Name = "text_errorPassword";
            this.text_errorPassword.Size = new System.Drawing.Size(0, 17);
            this.text_errorPassword.TabIndex = 18;
            // 
            // text_errorEmail
            // 
            this.text_errorEmail.AutoSize = true;
            this.text_errorEmail.BackColor = System.Drawing.SystemColors.ControlText;
            this.text_errorEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_errorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.text_errorEmail.ForeColor = System.Drawing.Color.Crimson;
            this.text_errorEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.text_errorEmail.Location = new System.Drawing.Point(433, 130);
            this.text_errorEmail.Name = "text_errorEmail";
            this.text_errorEmail.Size = new System.Drawing.Size(0, 17);
            this.text_errorEmail.TabIndex = 17;
            // 
            // UserSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 385);
            this.Controls.Add(this.text_errorPassword);
            this.Controls.Add(this.text_errorEmail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_sign_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_sign_email);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSignIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_sign_email;
        private System.Windows.Forms.TextBox text_sign_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label text_errorPassword;
        private System.Windows.Forms.Label text_errorEmail;
    }
}

