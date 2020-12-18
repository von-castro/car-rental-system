namespace Car_Rental_Application
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
            this.TextAddress1 = new System.Windows.Forms.TextBox();
            this.TextCity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboProvince = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextPhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextPostalCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextLicenseNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextLastName = new System.Windows.Forms.TextBox();
            this.TextFirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextAddress1
            // 
            this.TextAddress1.Location = new System.Drawing.Point(152, 36);
            this.TextAddress1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextAddress1.MaxLength = 30;
            this.TextAddress1.Name = "TextAddress1";
            this.TextAddress1.Size = new System.Drawing.Size(296, 28);
            this.TextAddress1.TabIndex = 0;
            // 
            // TextCity
            // 
            this.TextCity.Location = new System.Drawing.Point(152, 81);
            this.TextCity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextCity.MaxLength = 30;
            this.TextCity.Name = "TextCity";
            this.TextCity.Size = new System.Drawing.Size(296, 28);
            this.TextCity.TabIndex = 2;
            this.TextCity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboProvince);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextPhoneNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextPostalCode);
            this.groupBox1.Controls.Add(this.TextAddress1);
            this.groupBox1.Controls.Add(this.TextCity);
            this.groupBox1.Location = new System.Drawing.Point(20, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(477, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // ComboProvince
            // 
            this.ComboProvince.FormattingEnabled = true;
            this.ComboProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.ComboProvince.Location = new System.Drawing.Point(152, 123);
            this.ComboProvince.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ComboProvince.Name = "ComboProvince";
            this.ComboProvince.Size = new System.Drawing.Size(71, 29);
            this.ComboProvince.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // TextPhoneNum
            // 
            this.TextPhoneNum.Location = new System.Drawing.Point(152, 208);
            this.TextPhoneNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextPhoneNum.MaxLength = 10;
            this.TextPhoneNum.Name = "TextPhoneNum";
            this.TextPhoneNum.Size = new System.Drawing.Size(294, 28);
            this.TextPhoneNum.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postal Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Province";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Address 1";
            // 
            // TextPostalCode
            // 
            this.TextPostalCode.Location = new System.Drawing.Point(152, 166);
            this.TextPostalCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextPostalCode.MaxLength = 10;
            this.TextPostalCode.Name = "TextPostalCode";
            this.TextPostalCode.Size = new System.Drawing.Size(146, 28);
            this.TextPostalCode.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TextLicenseNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TextLastName);
            this.groupBox2.Controls.Add(this.TextFirstName);
            this.groupBox2.Location = new System.Drawing.Point(20, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(477, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "License Number";
            // 
            // TextLicenseNum
            // 
            this.TextLicenseNum.Location = new System.Drawing.Point(152, 115);
            this.TextLicenseNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextLicenseNum.MaxLength = 30;
            this.TextLicenseNum.Name = "TextLicenseNum";
            this.TextLicenseNum.Size = new System.Drawing.Size(294, 28);
            this.TextLicenseNum.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "First Name";
            // 
            // TextLastName
            // 
            this.TextLastName.Location = new System.Drawing.Point(152, 73);
            this.TextLastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextLastName.MaxLength = 15;
            this.TextLastName.Name = "TextLastName";
            this.TextLastName.Size = new System.Drawing.Size(294, 28);
            this.TextLastName.TabIndex = 6;
            // 
            // TextFirstName
            // 
            this.TextFirstName.Location = new System.Drawing.Point(152, 31);
            this.TextFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextFirstName.MaxLength = 15;
            this.TextFirstName.Name = "TextFirstName";
            this.TextFirstName.Size = new System.Drawing.Size(294, 28);
            this.TextFirstName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(162)))), ((int)(((byte)(159)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(347, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(517, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form2";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextAddress1;
        private System.Windows.Forms.TextBox TextCity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextPostalCode;
        private System.Windows.Forms.ComboBox ComboProvince;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextLastName;
        private System.Windows.Forms.TextBox TextFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextLicenseNum;
        private System.Windows.Forms.Button button1;
    }
}