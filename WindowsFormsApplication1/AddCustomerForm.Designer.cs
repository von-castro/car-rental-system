namespace Car_Rental_Application
{
    partial class AddCustomerForm
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
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DriversLicenseBox = new System.Windows.Forms.TextBox();
            this.DriverLicenseLabel = new System.Windows.Forms.Label();
            this.CustomerIDBox = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.ProvinceBox = new System.Windows.Forms.TextBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.PostalCodeBox = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(139, 112);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(196, 28);
            this.PhoneNumberBox.TabIndex = 4;
            this.PhoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(6, 115);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(127, 21);
            this.PhoneNumberLabel.TabIndex = 14;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(139, 78);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(196, 28);
            this.NameBox.TabIndex = 3;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(77, 81);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(56, 21);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Name";
            // 
            // DriversLicenseBox
            // 
            this.DriversLicenseBox.Location = new System.Drawing.Point(139, 44);
            this.DriversLicenseBox.Name = "DriversLicenseBox";
            this.DriversLicenseBox.Size = new System.Drawing.Size(196, 28);
            this.DriversLicenseBox.TabIndex = 2;
            this.DriversLicenseBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // DriverLicenseLabel
            // 
            this.DriverLicenseLabel.AutoSize = true;
            this.DriverLicenseLabel.Location = new System.Drawing.Point(11, 47);
            this.DriverLicenseLabel.Name = "DriverLicenseLabel";
            this.DriverLicenseLabel.Size = new System.Drawing.Size(122, 21);
            this.DriverLicenseLabel.TabIndex = 10;
            this.DriverLicenseLabel.Text = "Drivers License";
            // 
            // CustomerIDBox
            // 
            this.CustomerIDBox.Location = new System.Drawing.Point(139, 10);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.Size = new System.Drawing.Size(196, 28);
            this.CustomerIDBox.TabIndex = 1;
            this.CustomerIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(27, 13);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(106, 21);
            this.CustomerIDLabel.TabIndex = 7;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // ProvinceBox
            // 
            this.ProvinceBox.Location = new System.Drawing.Point(139, 214);
            this.ProvinceBox.Name = "ProvinceBox";
            this.ProvinceBox.Size = new System.Drawing.Size(196, 28);
            this.ProvinceBox.TabIndex = 7;
            this.ProvinceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(58, 217);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(75, 21);
            this.ProvinceLabel.TabIndex = 21;
            this.ProvinceLabel.Text = "Province";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(139, 180);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(196, 28);
            this.CityBox.TabIndex = 6;
            this.CityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(94, 183);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(39, 21);
            this.CityLabel.TabIndex = 18;
            this.CityLabel.Text = "City";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(139, 146);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(196, 28);
            this.AddressBox.TabIndex = 5;
            this.AddressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(63, 149);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(70, 21);
            this.AddressLabel.TabIndex = 15;
            this.AddressLabel.Text = "Address";
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(162)))), ((int)(((byte)(159)))));
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.Location = new System.Drawing.Point(139, 282);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(196, 41);
            this.AddCustomerButton.TabIndex = 22;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            this.AddCustomerButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // PostalCodeBox
            // 
            this.PostalCodeBox.Location = new System.Drawing.Point(139, 248);
            this.PostalCodeBox.Name = "PostalCodeBox";
            this.PostalCodeBox.Size = new System.Drawing.Size(196, 28);
            this.PostalCodeBox.TabIndex = 8;
            this.PostalCodeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomer_KeyPress);
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(32, 251);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(101, 21);
            this.PostalCodeLabel.TabIndex = 24;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(343, 331);
            this.Controls.Add(this.PostalCodeBox);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.ProvinceBox);
            this.Controls.Add(this.ProvinceLabel);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DriversLicenseBox);
            this.Controls.Add(this.DriverLicenseLabel);
            this.Controls.Add(this.CustomerIDBox);
            this.Controls.Add(this.CustomerIDLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox DriversLicenseBox;
        private System.Windows.Forms.Label DriverLicenseLabel;
        private System.Windows.Forms.TextBox CustomerIDBox;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox ProvinceBox;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.TextBox PostalCodeBox;
        private System.Windows.Forms.Label PostalCodeLabel;
    }
}