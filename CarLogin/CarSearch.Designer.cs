namespace CarLogin
{
    partial class CarSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSearch));
            this.cmbx_city = new System.Windows.Forms.ComboBox();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.cmbx_year = new System.Windows.Forms.ComboBox();
            this.cmbx_marka = new System.Windows.Forms.ComboBox();
            this.txbx_welcome = new System.Windows.Forms.Label();
            this.txbx_welcome2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbx_city
            // 
            this.cmbx_city.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbx_city.FormattingEnabled = true;
            this.cmbx_city.Location = new System.Drawing.Point(538, 143);
            this.cmbx_city.Name = "cmbx_city";
            this.cmbx_city.Size = new System.Drawing.Size(160, 21);
            this.cmbx_city.TabIndex = 7;
            // 
            // cmb_model
            // 
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Location = new System.Drawing.Point(160, 205);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(160, 21);
            this.cmb_model.TabIndex = 10;
            this.cmb_model.SelectedIndexChanged += new System.EventHandler(this.cmb_model_SelectedIndexChanged);
            // 
            // cmbx_year
            // 
            this.cmbx_year.FormattingEnabled = true;
            this.cmbx_year.Location = new System.Drawing.Point(538, 208);
            this.cmbx_year.Name = "cmbx_year";
            this.cmbx_year.Size = new System.Drawing.Size(160, 21);
            this.cmbx_year.TabIndex = 9;
            // 
            // cmbx_marka
            // 
            this.cmbx_marka.FormattingEnabled = true;
            this.cmbx_marka.Location = new System.Drawing.Point(160, 140);
            this.cmbx_marka.Name = "cmbx_marka";
            this.cmbx_marka.Size = new System.Drawing.Size(160, 21);
            this.cmbx_marka.TabIndex = 8;
            this.cmbx_marka.SelectedIndexChanged += new System.EventHandler(this.cmb__SelectedIndexChanged);
            // 
            // txbx_welcome
            // 
            this.txbx_welcome.AutoSize = true;
            this.txbx_welcome.BackColor = System.Drawing.Color.Black;
            this.txbx_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_welcome.ForeColor = System.Drawing.Color.Crimson;
            this.txbx_welcome.Location = new System.Drawing.Point(126, 10);
            this.txbx_welcome.Name = "txbx_welcome";
            this.txbx_welcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbx_welcome.Size = new System.Drawing.Size(0, 20);
            this.txbx_welcome.TabIndex = 13;
            // 
            // txbx_welcome2
            // 
            this.txbx_welcome2.AutoSize = true;
            this.txbx_welcome2.BackColor = System.Drawing.Color.Black;
            this.txbx_welcome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_welcome2.ForeColor = System.Drawing.Color.Crimson;
            this.txbx_welcome2.Location = new System.Drawing.Point(203, 10);
            this.txbx_welcome2.Name = "txbx_welcome2";
            this.txbx_welcome2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbx_welcome2.Size = new System.Drawing.Size(0, 20);
            this.txbx_welcome2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(72, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Model:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(458, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(70, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Marka:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(469, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "City:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button3.ForeColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(334, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 30);
            this.button3.TabIndex = 23;
            this.button3.Text = "SEARCH";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(729, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CarSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_welcome2);
            this.Controls.Add(this.txbx_welcome);
            this.Controls.Add(this.cmbx_city);
            this.Controls.Add(this.cmb_model);
            this.Controls.Add(this.cmbx_year);
            this.Controls.Add(this.cmbx_marka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarSearch";
            this.Text = "CarSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbx_city;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.ComboBox cmbx_year;
        private System.Windows.Forms.ComboBox cmbx_marka;
        private System.Windows.Forms.Label txbx_welcome;
        private System.Windows.Forms.Label txbx_welcome2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}