namespace Car_Rental_Application
{
    partial class EditTransactionForm
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
            this.InEmployeeIDDropBox = new System.Windows.Forms.ComboBox();
            this.TotalBalanceBox = new System.Windows.Forms.TextBox();
            this.TotalBalanceLabel = new System.Windows.Forms.Label();
            this.EditTransactionButton = new System.Windows.Forms.Button();
            this.PaymentInformationBox = new System.Windows.Forms.TextBox();
            this.PaymentInformationLabel = new System.Windows.Forms.Label();
            this.InEmployeeIDLabel = new System.Windows.Forms.Label();
            this.OutEmployeeIDDropBox = new System.Windows.Forms.ComboBox();
            this.OutEmployeeIDLabel = new System.Windows.Forms.Label();
            this.InBranchIDDropBox = new System.Windows.Forms.ComboBox();
            this.OutBranchIDDropBox = new System.Windows.Forms.ComboBox();
            this.DateExpectedInPicker = new System.Windows.Forms.DateTimePicker();
            this.DateOutPicker = new System.Windows.Forms.DateTimePicker();
            this.VINDropBox = new System.Windows.Forms.ComboBox();
            this.CustomerIDDropBox = new System.Windows.Forms.ComboBox();
            this.TransactionIDBox = new System.Windows.Forms.TextBox();
            this.InBranchIDLabel = new System.Windows.Forms.Label();
            this.OutBranchIDLabel = new System.Windows.Forms.Label();
            this.DateExpectedInLabel = new System.Windows.Forms.Label();
            this.DateOutLabel = new System.Windows.Forms.Label();
            this.VINLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.TransactionIDLabel = new System.Windows.Forms.Label();
            this.DateInPicker = new System.Windows.Forms.DateTimePicker();
            this.DateInLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InEmployeeIDDropBox
            // 
            this.InEmployeeIDDropBox.FormattingEnabled = true;
            this.InEmployeeIDDropBox.Location = new System.Drawing.Point(190, 323);
            this.InEmployeeIDDropBox.Name = "InEmployeeIDDropBox";
            this.InEmployeeIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.InEmployeeIDDropBox.TabIndex = 10;
            this.InEmployeeIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // TotalBalanceBox
            // 
            this.TotalBalanceBox.Location = new System.Drawing.Point(190, 391);
            this.TotalBalanceBox.Name = "TotalBalanceBox";
            this.TotalBalanceBox.Size = new System.Drawing.Size(200, 28);
            this.TotalBalanceBox.TabIndex = 12;
            this.TotalBalanceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // TotalBalanceLabel
            // 
            this.TotalBalanceLabel.AutoSize = true;
            this.TotalBalanceLabel.Location = new System.Drawing.Point(72, 394);
            this.TotalBalanceLabel.Name = "TotalBalanceLabel";
            this.TotalBalanceLabel.Size = new System.Drawing.Size(112, 21);
            this.TotalBalanceLabel.TabIndex = 44;
            this.TotalBalanceLabel.Text = "Total Balance";
            // 
            // EditTransactionButton
            // 
            this.EditTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(162)))), ((int)(((byte)(159)))));
            this.EditTransactionButton.FlatAppearance.BorderSize = 0;
            this.EditTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTransactionButton.ForeColor = System.Drawing.Color.White;
            this.EditTransactionButton.Location = new System.Drawing.Point(190, 425);
            this.EditTransactionButton.Name = "EditTransactionButton";
            this.EditTransactionButton.Size = new System.Drawing.Size(200, 41);
            this.EditTransactionButton.TabIndex = 13;
            this.EditTransactionButton.Text = "Edit Transaction";
            this.EditTransactionButton.UseVisualStyleBackColor = false;
            this.EditTransactionButton.Click += new System.EventHandler(this.EditTransactionButton_Click);
            this.EditTransactionButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // PaymentInformationBox
            // 
            this.PaymentInformationBox.Location = new System.Drawing.Point(190, 357);
            this.PaymentInformationBox.Name = "PaymentInformationBox";
            this.PaymentInformationBox.Size = new System.Drawing.Size(200, 28);
            this.PaymentInformationBox.TabIndex = 11;
            this.PaymentInformationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // PaymentInformationLabel
            // 
            this.PaymentInformationLabel.AutoSize = true;
            this.PaymentInformationLabel.Location = new System.Drawing.Point(11, 360);
            this.PaymentInformationLabel.Name = "PaymentInformationLabel";
            this.PaymentInformationLabel.Size = new System.Drawing.Size(173, 21);
            this.PaymentInformationLabel.TabIndex = 42;
            this.PaymentInformationLabel.Text = "Payment Information";
            // 
            // InEmployeeIDLabel
            // 
            this.InEmployeeIDLabel.AutoSize = true;
            this.InEmployeeIDLabel.Location = new System.Drawing.Point(80, 326);
            this.InEmployeeIDLabel.Name = "InEmployeeIDLabel";
            this.InEmployeeIDLabel.Size = new System.Drawing.Size(104, 21);
            this.InEmployeeIDLabel.TabIndex = 41;
            this.InEmployeeIDLabel.Text = "In Employee";
            // 
            // OutEmployeeIDDropBox
            // 
            this.OutEmployeeIDDropBox.Enabled = false;
            this.OutEmployeeIDDropBox.FormattingEnabled = true;
            this.OutEmployeeIDDropBox.Location = new System.Drawing.Point(190, 288);
            this.OutEmployeeIDDropBox.Name = "OutEmployeeIDDropBox";
            this.OutEmployeeIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.OutEmployeeIDDropBox.TabIndex = 9;
            this.OutEmployeeIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // OutEmployeeIDLabel
            // 
            this.OutEmployeeIDLabel.AutoSize = true;
            this.OutEmployeeIDLabel.Location = new System.Drawing.Point(66, 291);
            this.OutEmployeeIDLabel.Name = "OutEmployeeIDLabel";
            this.OutEmployeeIDLabel.Size = new System.Drawing.Size(118, 21);
            this.OutEmployeeIDLabel.TabIndex = 40;
            this.OutEmployeeIDLabel.Text = "Out Employee";
            // 
            // InBranchIDDropBox
            // 
            this.InBranchIDDropBox.FormattingEnabled = true;
            this.InBranchIDDropBox.Location = new System.Drawing.Point(190, 253);
            this.InBranchIDDropBox.Name = "InBranchIDDropBox";
            this.InBranchIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.InBranchIDDropBox.TabIndex = 8;
            this.InBranchIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // OutBranchIDDropBox
            // 
            this.OutBranchIDDropBox.FormattingEnabled = true;
            this.OutBranchIDDropBox.Location = new System.Drawing.Point(190, 218);
            this.OutBranchIDDropBox.Name = "OutBranchIDDropBox";
            this.OutBranchIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.OutBranchIDDropBox.TabIndex = 7;
            this.OutBranchIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // DateExpectedInPicker
            // 
            this.DateExpectedInPicker.Location = new System.Drawing.Point(190, 115);
            this.DateExpectedInPicker.Name = "DateExpectedInPicker";
            this.DateExpectedInPicker.Size = new System.Drawing.Size(200, 28);
            this.DateExpectedInPicker.TabIndex = 4;
            this.DateExpectedInPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // DateOutPicker
            // 
            this.DateOutPicker.Location = new System.Drawing.Point(190, 81);
            this.DateOutPicker.Name = "DateOutPicker";
            this.DateOutPicker.Size = new System.Drawing.Size(200, 28);
            this.DateOutPicker.TabIndex = 3;
            this.DateOutPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // VINDropBox
            // 
            this.VINDropBox.Enabled = false;
            this.VINDropBox.FormattingEnabled = true;
            this.VINDropBox.Location = new System.Drawing.Point(190, 183);
            this.VINDropBox.Name = "VINDropBox";
            this.VINDropBox.Size = new System.Drawing.Size(200, 29);
            this.VINDropBox.TabIndex = 6;
            this.VINDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // CustomerIDDropBox
            // 
            this.CustomerIDDropBox.FormattingEnabled = true;
            this.CustomerIDDropBox.Location = new System.Drawing.Point(190, 46);
            this.CustomerIDDropBox.Name = "CustomerIDDropBox";
            this.CustomerIDDropBox.Size = new System.Drawing.Size(200, 29);
            this.CustomerIDDropBox.TabIndex = 2;
            this.CustomerIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // TransactionIDBox
            // 
            this.TransactionIDBox.Enabled = false;
            this.TransactionIDBox.Location = new System.Drawing.Point(190, 12);
            this.TransactionIDBox.Name = "TransactionIDBox";
            this.TransactionIDBox.Size = new System.Drawing.Size(200, 28);
            this.TransactionIDBox.TabIndex = 1;
            this.TransactionIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // InBranchIDLabel
            // 
            this.InBranchIDLabel.AutoSize = true;
            this.InBranchIDLabel.Location = new System.Drawing.Point(101, 256);
            this.InBranchIDLabel.Name = "InBranchIDLabel";
            this.InBranchIDLabel.Size = new System.Drawing.Size(83, 21);
            this.InBranchIDLabel.TabIndex = 33;
            this.InBranchIDLabel.Text = "In Branch";
            // 
            // OutBranchIDLabel
            // 
            this.OutBranchIDLabel.AutoSize = true;
            this.OutBranchIDLabel.Location = new System.Drawing.Point(87, 221);
            this.OutBranchIDLabel.Name = "OutBranchIDLabel";
            this.OutBranchIDLabel.Size = new System.Drawing.Size(97, 21);
            this.OutBranchIDLabel.TabIndex = 31;
            this.OutBranchIDLabel.Text = "Out Branch";
            // 
            // DateExpectedInLabel
            // 
            this.DateExpectedInLabel.AutoSize = true;
            this.DateExpectedInLabel.Location = new System.Drawing.Point(44, 121);
            this.DateExpectedInLabel.Name = "DateExpectedInLabel";
            this.DateExpectedInLabel.Size = new System.Drawing.Size(140, 21);
            this.DateExpectedInLabel.TabIndex = 29;
            this.DateExpectedInLabel.Text = "Date Expected In";
            // 
            // DateOutLabel
            // 
            this.DateOutLabel.AutoSize = true;
            this.DateOutLabel.Location = new System.Drawing.Point(104, 87);
            this.DateOutLabel.Name = "DateOutLabel";
            this.DateOutLabel.Size = new System.Drawing.Size(80, 21);
            this.DateOutLabel.TabIndex = 27;
            this.DateOutLabel.Text = "Date Out";
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(145, 186);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(39, 21);
            this.VINLabel.TabIndex = 25;
            this.VINLabel.Text = "VIN";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(49, 49);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(135, 21);
            this.CustomerIDLabel.TabIndex = 24;
            this.CustomerIDLabel.Text = "Customer Name";
            // 
            // TransactionIDLabel
            // 
            this.TransactionIDLabel.AutoSize = true;
            this.TransactionIDLabel.Location = new System.Drawing.Point(64, 15);
            this.TransactionIDLabel.Name = "TransactionIDLabel";
            this.TransactionIDLabel.Size = new System.Drawing.Size(120, 21);
            this.TransactionIDLabel.TabIndex = 22;
            this.TransactionIDLabel.Text = "Transaction ID";
            // 
            // DateInPicker
            // 
            this.DateInPicker.Location = new System.Drawing.Point(190, 149);
            this.DateInPicker.Name = "DateInPicker";
            this.DateInPicker.Size = new System.Drawing.Size(200, 28);
            this.DateInPicker.TabIndex = 5;
            this.DateInPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditTransactionButton_KeyPress);
            // 
            // DateInLabel
            // 
            this.DateInLabel.AutoSize = true;
            this.DateInLabel.Location = new System.Drawing.Point(118, 155);
            this.DateInLabel.Name = "DateInLabel";
            this.DateInLabel.Size = new System.Drawing.Size(66, 21);
            this.DateInLabel.TabIndex = 45;
            this.DateInLabel.Text = "Date In";
            // 
            // EditTransactionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.DateInPicker);
            this.Controls.Add(this.DateInLabel);
            this.Controls.Add(this.InEmployeeIDDropBox);
            this.Controls.Add(this.TotalBalanceBox);
            this.Controls.Add(this.TotalBalanceLabel);
            this.Controls.Add(this.EditTransactionButton);
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
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditTransactionForm";
            this.Text = "Edit Transaction";
            this.Load += new System.EventHandler(this.EditTransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InEmployeeIDDropBox;
        private System.Windows.Forms.TextBox TotalBalanceBox;
        private System.Windows.Forms.Label TotalBalanceLabel;
        private System.Windows.Forms.Button EditTransactionButton;
        private System.Windows.Forms.TextBox PaymentInformationBox;
        private System.Windows.Forms.Label PaymentInformationLabel;
        private System.Windows.Forms.Label InEmployeeIDLabel;
        private System.Windows.Forms.ComboBox OutEmployeeIDDropBox;
        private System.Windows.Forms.Label OutEmployeeIDLabel;
        private System.Windows.Forms.ComboBox InBranchIDDropBox;
        private System.Windows.Forms.ComboBox OutBranchIDDropBox;
        private System.Windows.Forms.DateTimePicker DateExpectedInPicker;
        private System.Windows.Forms.DateTimePicker DateOutPicker;
        private System.Windows.Forms.ComboBox VINDropBox;
        private System.Windows.Forms.ComboBox CustomerIDDropBox;
        private System.Windows.Forms.TextBox TransactionIDBox;
        private System.Windows.Forms.Label InBranchIDLabel;
        private System.Windows.Forms.Label OutBranchIDLabel;
        private System.Windows.Forms.Label DateExpectedInLabel;
        private System.Windows.Forms.Label DateOutLabel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label TransactionIDLabel;
        private System.Windows.Forms.DateTimePicker DateInPicker;
        private System.Windows.Forms.Label DateInLabel;
    }
}