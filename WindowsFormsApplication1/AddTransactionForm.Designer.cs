namespace Car_Rental_Application
{
    partial class AddTransactionForm
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
            this.TransactionIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.VINLabel = new System.Windows.Forms.Label();
            this.DateOutLabel = new System.Windows.Forms.Label();
            this.DateExpectedInLabel = new System.Windows.Forms.Label();
            this.OutBranchIDLabel = new System.Windows.Forms.Label();
            this.InBranchIDLabel = new System.Windows.Forms.Label();
            this.TransactionIDBox = new System.Windows.Forms.TextBox();
            this.CustomerIDDropBox = new System.Windows.Forms.ComboBox();
            this.VINDropBox = new System.Windows.Forms.ComboBox();
            this.DateOutPicker = new System.Windows.Forms.DateTimePicker();
            this.DateExpectedInPicker = new System.Windows.Forms.DateTimePicker();
            this.OutBranchIDDropBox = new System.Windows.Forms.ComboBox();
            this.InBranchIDDropBox = new System.Windows.Forms.ComboBox();
            this.OutEmployeeIDDropBox = new System.Windows.Forms.ComboBox();
            this.OutEmployeeIDLabel = new System.Windows.Forms.Label();
            this.InEmployeeIDLabel = new System.Windows.Forms.Label();
            this.PaymentInformationBox = new System.Windows.Forms.TextBox();
            this.PaymentInformationLabel = new System.Windows.Forms.Label();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.TotalBalanceBox = new System.Windows.Forms.TextBox();
            this.TotalBalanceLabel = new System.Windows.Forms.Label();
            this.InEmployeeIDDropBox = new System.Windows.Forms.ComboBox();
            this.DateInPicker = new System.Windows.Forms.DateTimePicker();
            this.DateInLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransactionIDLabel
            // 
            this.TransactionIDLabel.AutoSize = true;
            this.TransactionIDLabel.Location = new System.Drawing.Point(64, 15);
            this.TransactionIDLabel.Name = "TransactionIDLabel";
            this.TransactionIDLabel.Size = new System.Drawing.Size(120, 21);
            this.TransactionIDLabel.TabIndex = 0;
            this.TransactionIDLabel.Text = "Transaction ID";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(49, 49);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(135, 21);
            this.CustomerIDLabel.TabIndex = 1;
            this.CustomerIDLabel.Text = "Customer Name";
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(145, 186);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(39, 21);
            this.VINLabel.TabIndex = 2;
            this.VINLabel.Text = "VIN";
            // 
            // DateOutLabel
            // 
            this.DateOutLabel.AutoSize = true;
            this.DateOutLabel.Location = new System.Drawing.Point(104, 87);
            this.DateOutLabel.Name = "DateOutLabel";
            this.DateOutLabel.Size = new System.Drawing.Size(80, 21);
            this.DateOutLabel.TabIndex = 3;
            this.DateOutLabel.Text = "Date Out";
            // 
            // DateExpectedInLabel
            // 
            this.DateExpectedInLabel.AutoSize = true;
            this.DateExpectedInLabel.Location = new System.Drawing.Point(44, 121);
            this.DateExpectedInLabel.Name = "DateExpectedInLabel";
            this.DateExpectedInLabel.Size = new System.Drawing.Size(140, 21);
            this.DateExpectedInLabel.TabIndex = 4;
            this.DateExpectedInLabel.Text = "Date Expected In";
            // 
            // OutBranchIDLabel
            // 
            this.OutBranchIDLabel.AutoSize = true;
            this.OutBranchIDLabel.Location = new System.Drawing.Point(87, 221);
            this.OutBranchIDLabel.Name = "OutBranchIDLabel";
            this.OutBranchIDLabel.Size = new System.Drawing.Size(97, 21);
            this.OutBranchIDLabel.TabIndex = 5;
            this.OutBranchIDLabel.Text = "Out Branch";
            // 
            // InBranchIDLabel
            // 
            this.InBranchIDLabel.AutoSize = true;
            this.InBranchIDLabel.Location = new System.Drawing.Point(101, 256);
            this.InBranchIDLabel.Name = "InBranchIDLabel";
            this.InBranchIDLabel.Size = new System.Drawing.Size(83, 21);
            this.InBranchIDLabel.TabIndex = 6;
            this.InBranchIDLabel.Text = "In Branch";
            // 
            // TransactionIDBox
            // 
            this.TransactionIDBox.Location = new System.Drawing.Point(190, 12);
            this.TransactionIDBox.Name = "TransactionIDBox";
            this.TransactionIDBox.Size = new System.Drawing.Size(200, 28);
            this.TransactionIDBox.TabIndex = 1;
            this.TransactionIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // CustomerIDDropBox
            // 
            this.CustomerIDDropBox.FormattingEnabled = true;
            this.CustomerIDDropBox.Location = new System.Drawing.Point(190, 46);
            this.CustomerIDDropBox.Name = "CustomerIDDropBox";
            this.CustomerIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.CustomerIDDropBox.TabIndex = 2;
            this.CustomerIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // VINDropBox
            // 
            this.VINDropBox.FormattingEnabled = true;
            this.VINDropBox.Location = new System.Drawing.Point(190, 183);
            this.VINDropBox.Name = "VINDropBox";
            this.VINDropBox.Size = new System.Drawing.Size(200, 29);
            this.VINDropBox.TabIndex = 6;
            this.VINDropBox.Enter += new System.EventHandler(this.VINDropBox_Enter);
            this.VINDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // DateOutPicker
            // 
            this.DateOutPicker.Location = new System.Drawing.Point(190, 81);
            this.DateOutPicker.Name = "DateOutPicker";
            this.DateOutPicker.Size = new System.Drawing.Size(200, 28);
            this.DateOutPicker.TabIndex = 3;
            this.DateOutPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // DateExpectedInPicker
            // 
            this.DateExpectedInPicker.Location = new System.Drawing.Point(190, 115);
            this.DateExpectedInPicker.Name = "DateExpectedInPicker";
            this.DateExpectedInPicker.Size = new System.Drawing.Size(200, 28);
            this.DateExpectedInPicker.TabIndex = 4;
            this.DateExpectedInPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // OutBranchIDDropBox
            // 
            this.OutBranchIDDropBox.FormattingEnabled = true;
            this.OutBranchIDDropBox.Location = new System.Drawing.Point(190, 218);
            this.OutBranchIDDropBox.Name = "OutBranchIDDropBox";
            this.OutBranchIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.OutBranchIDDropBox.TabIndex = 7;
            this.OutBranchIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // InBranchIDDropBox
            // 
            this.InBranchIDDropBox.Enabled = false;
            this.InBranchIDDropBox.FormattingEnabled = true;
            this.InBranchIDDropBox.Location = new System.Drawing.Point(190, 253);
            this.InBranchIDDropBox.Name = "InBranchIDDropBox";
            this.InBranchIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.InBranchIDDropBox.TabIndex = 8;
            this.InBranchIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // OutEmployeeIDDropBox
            // 
            this.OutEmployeeIDDropBox.Enabled = false;
            this.OutEmployeeIDDropBox.FormattingEnabled = true;
            this.OutEmployeeIDDropBox.Location = new System.Drawing.Point(190, 288);
            this.OutEmployeeIDDropBox.Name = "OutEmployeeIDDropBox";
            this.OutEmployeeIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.OutEmployeeIDDropBox.TabIndex = 9;
            this.OutEmployeeIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // OutEmployeeIDLabel
            // 
            this.OutEmployeeIDLabel.AutoSize = true;
            this.OutEmployeeIDLabel.Location = new System.Drawing.Point(66, 291);
            this.OutEmployeeIDLabel.Name = "OutEmployeeIDLabel";
            this.OutEmployeeIDLabel.Size = new System.Drawing.Size(118, 21);
            this.OutEmployeeIDLabel.TabIndex = 14;
            this.OutEmployeeIDLabel.Text = "Out Employee";
            // 
            // InEmployeeIDLabel
            // 
            this.InEmployeeIDLabel.AutoSize = true;
            this.InEmployeeIDLabel.Location = new System.Drawing.Point(80, 326);
            this.InEmployeeIDLabel.Name = "InEmployeeIDLabel";
            this.InEmployeeIDLabel.Size = new System.Drawing.Size(104, 21);
            this.InEmployeeIDLabel.TabIndex = 16;
            this.InEmployeeIDLabel.Text = "In Employee";
            // 
            // PaymentInformationBox
            // 
            this.PaymentInformationBox.Location = new System.Drawing.Point(190, 357);
            this.PaymentInformationBox.Name = "PaymentInformationBox";
            this.PaymentInformationBox.Size = new System.Drawing.Size(200, 28);
            this.PaymentInformationBox.TabIndex = 11;
            this.PaymentInformationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // PaymentInformationLabel
            // 
            this.PaymentInformationLabel.AutoSize = true;
            this.PaymentInformationLabel.Location = new System.Drawing.Point(11, 360);
            this.PaymentInformationLabel.Name = "PaymentInformationLabel";
            this.PaymentInformationLabel.Size = new System.Drawing.Size(173, 21);
            this.PaymentInformationLabel.TabIndex = 18;
            this.PaymentInformationLabel.Text = "Payment Information";
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(162)))), ((int)(((byte)(159)))));
            this.AddTransactionButton.FlatAppearance.BorderSize = 0;
            this.AddTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransactionButton.ForeColor = System.Drawing.Color.White;
            this.AddTransactionButton.Location = new System.Drawing.Point(190, 425);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(200, 41);
            this.AddTransactionButton.TabIndex = 13;
            this.AddTransactionButton.Text = "Add Transaction";
            this.AddTransactionButton.UseVisualStyleBackColor = false;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            this.AddTransactionButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // TotalBalanceBox
            // 
            this.TotalBalanceBox.Enabled = false;
            this.TotalBalanceBox.Location = new System.Drawing.Point(190, 391);
            this.TotalBalanceBox.Name = "TotalBalanceBox";
            this.TotalBalanceBox.Size = new System.Drawing.Size(200, 28);
            this.TotalBalanceBox.TabIndex = 12;
            this.TotalBalanceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // TotalBalanceLabel
            // 
            this.TotalBalanceLabel.AutoSize = true;
            this.TotalBalanceLabel.Location = new System.Drawing.Point(72, 394);
            this.TotalBalanceLabel.Name = "TotalBalanceLabel";
            this.TotalBalanceLabel.Size = new System.Drawing.Size(112, 21);
            this.TotalBalanceLabel.TabIndex = 21;
            this.TotalBalanceLabel.Text = "Total Balance";
            // 
            // InEmployeeIDDropBox
            // 
            this.InEmployeeIDDropBox.Enabled = false;
            this.InEmployeeIDDropBox.FormattingEnabled = true;
            this.InEmployeeIDDropBox.Location = new System.Drawing.Point(190, 323);
            this.InEmployeeIDDropBox.Name = "InEmployeeIDDropBox";
            this.InEmployeeIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.InEmployeeIDDropBox.TabIndex = 10;
            this.InEmployeeIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // DateInPicker
            // 
            this.DateInPicker.Enabled = false;
            this.DateInPicker.Location = new System.Drawing.Point(190, 149);
            this.DateInPicker.Name = "DateInPicker";
            this.DateInPicker.Size = new System.Drawing.Size(200, 28);
            this.DateInPicker.TabIndex = 5;
            this.DateInPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTransactionButton_KeyPress);
            // 
            // DateInLabel
            // 
            this.DateInLabel.AutoSize = true;
            this.DateInLabel.Location = new System.Drawing.Point(118, 155);
            this.DateInLabel.Name = "DateInLabel";
            this.DateInLabel.Size = new System.Drawing.Size(66, 21);
            this.DateInLabel.TabIndex = 22;
            this.DateInLabel.Text = "Date In";
            // 
            // AddTransactionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.DateInPicker);
            this.Controls.Add(this.DateInLabel);
            this.Controls.Add(this.InEmployeeIDDropBox);
            this.Controls.Add(this.TotalBalanceBox);
            this.Controls.Add(this.TotalBalanceLabel);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.PaymentInformationBox);
            this.Controls.Add(this.PaymentInformationLabel);
            this.Controls.Add(this.InEmployeeIDLabel);
            this.Controls.Add(this.OutEmployeeIDDropBox);
            this.Controls.Add(this.OutEmployeeIDLabel);
            this.Controls.Add(this.InBranchIDDropBox);
            this.Controls.Add(this.OutBranchIDDropBox);
            this.Controls.Add(this.DateExpectedInPicker);
            this.Controls.Add(this.DateOutPicker);
            this.Controls.Add(this.VINDropBox);
            this.Controls.Add(this.CustomerIDDropBox);
            this.Controls.Add(this.TransactionIDBox);
            this.Controls.Add(this.InBranchIDLabel);
            this.Controls.Add(this.OutBranchIDLabel);
            this.Controls.Add(this.DateExpectedInLabel);
            this.Controls.Add(this.DateOutLabel);
            this.Controls.Add(this.VINLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.TransactionIDLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddTransactionForm";
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransactionIDLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Label DateOutLabel;
        private System.Windows.Forms.Label DateExpectedInLabel;
        private System.Windows.Forms.Label OutBranchIDLabel;
        private System.Windows.Forms.Label InBranchIDLabel;
        private System.Windows.Forms.TextBox TransactionIDBox;
        private System.Windows.Forms.ComboBox CustomerIDDropBox;
        private System.Windows.Forms.ComboBox VINDropBox;
        private System.Windows.Forms.DateTimePicker DateOutPicker;
        private System.Windows.Forms.DateTimePicker DateExpectedInPicker;
        private System.Windows.Forms.ComboBox OutBranchIDDropBox;
        private System.Windows.Forms.ComboBox InBranchIDDropBox;
        private System.Windows.Forms.ComboBox OutEmployeeIDDropBox;
        private System.Windows.Forms.Label OutEmployeeIDLabel;
        private System.Windows.Forms.TextBox PaymentInformationBox;
        private System.Windows.Forms.Label PaymentInformationLabel;
        private System.Windows.Forms.Button AddTransactionButton;
        private System.Windows.Forms.Label InEmployeeIDLabel;
        private System.Windows.Forms.TextBox TotalBalanceBox;
        private System.Windows.Forms.Label TotalBalanceLabel;
        private System.Windows.Forms.ComboBox InEmployeeIDDropBox;
        private System.Windows.Forms.DateTimePicker DateInPicker;
        private System.Windows.Forms.Label DateInLabel;
    }
}