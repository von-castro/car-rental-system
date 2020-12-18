namespace Car_Rental_Application
{
    partial class EditCarForm
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
            this.BranchIDDropBox = new System.Windows.Forms.ComboBox();
            this.CarTypeDropBox = new System.Windows.Forms.ComboBox();
            this.SubmitChangesButton = new System.Windows.Forms.Button();
            this.BranchIDLabel = new System.Windows.Forms.Label();
            this.CarTypeLabel = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.VINBox = new System.Windows.Forms.TextBox();
            this.VINLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BranchIDDropBox
            // 
            this.BranchIDDropBox.FormattingEnabled = true;
            this.BranchIDDropBox.Location = new System.Drawing.Point(103, 179);
            this.BranchIDDropBox.Name = "BranchIDDropBox";
            this.BranchIDDropBox.Size = new System.Drawing.Size(196, 29);
            this.BranchIDDropBox.TabIndex = 6;
            this.BranchIDDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCar_KeyPress);
            // 
            // CarTypeDropBox
            // 
            this.CarTypeDropBox.FormattingEnabled = true;
            this.CarTypeDropBox.Location = new System.Drawing.Point(103, 145);
            this.CarTypeDropBox.Name = "CarTypeDropBox";
            this.CarTypeDropBox.Size = new System.Drawing.Size(196, 29);
            this.CarTypeDropBox.TabIndex = 5;
            this.CarTypeDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCar_KeyPress);
            // 
            // SubmitChangesButton
            // 
            this.SubmitChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(162)))), ((int)(((byte)(159)))));
            this.SubmitChangesButton.FlatAppearance.BorderSize = 0;
            this.SubmitChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitChangesButton.ForeColor = System.Drawing.Color.White;
            this.SubmitChangesButton.Location = new System.Drawing.Point(103, 214);
            this.SubmitChangesButton.Name = "SubmitChangesButton";
            this.SubmitChangesButton.Size = new System.Drawing.Size(196, 41);
            this.SubmitChangesButton.TabIndex = 25;
            this.SubmitChangesButton.Text = "Submit Changes";
            this.SubmitChangesButton.UseVisualStyleBackColor = false;
            this.SubmitChangesButton.Click += new System.EventHandler(this.SubmitChangesButton_Click);
            // 
            // BranchIDLabel
            // 
            this.BranchIDLabel.AutoSize = true;
            this.BranchIDLabel.Location = new System.Drawing.Point(12, 183);
            this.BranchIDLabel.Name = "BranchIDLabel";
            this.BranchIDLabel.Size = new System.Drawing.Size(85, 21);
            this.BranchIDLabel.TabIndex = 24;
            this.BranchIDLabel.Text = "Branch ID";
            // 
            // CarTypeLabel
            // 
            this.CarTypeLabel.AutoSize = true;
            this.CarTypeLabel.Location = new System.Drawing.Point(20, 149);
            this.CarTypeLabel.Name = "CarTypeLabel";
            this.CarTypeLabel.Size = new System.Drawing.Size(77, 21);
            this.CarTypeLabel.TabIndex = 23;
            this.CarTypeLabel.Text = "Car Type";
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(103, 112);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(196, 28);
            this.ColorBox.TabIndex = 4;
            this.ColorBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCar_KeyPress);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(46, 115);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(51, 21);
            this.ColorLabel.TabIndex = 21;
            this.ColorLabel.Text = "Color";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(103, 78);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(196, 28);
            this.ModelBox.TabIndex = 3;
            this.ModelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCar_KeyPress);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(38, 81);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(59, 21);
            this.ModelLabel.TabIndex = 19;
            this.ModelLabel.Text = "Model";
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(103, 44);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(196, 28);
            this.MakeBox.TabIndex = 2;
            this.MakeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCar_KeyPress);
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(44, 47);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(53, 21);
            this.MakeLabel.TabIndex = 17;
            this.MakeLabel.Text = "Make";
            // 
            // VINBox
            // 
            this.VINBox.Location = new System.Drawing.Point(103, 10);
            this.VINBox.Name = "VINBox";
            this.VINBox.Size = new System.Drawing.Size(196, 28);
            this.VINBox.TabIndex = 1;
            this.VINBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCar_KeyPress);
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(58, 13);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(39, 21);
            this.VINLabel.TabIndex = 15;
            this.VINLabel.Text = "VIN";
            // 
            // EditCarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(311, 265);
            this.Controls.Add(this.BranchIDDropBox);
            this.Controls.Add(this.CarTypeDropBox);
            this.Controls.Add(this.SubmitChangesButton);
            this.Controls.Add(this.BranchIDLabel);
            this.Controls.Add(this.CarTypeLabel);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.MakeLabel);
            this.Controls.Add(this.VINBox);
            this.Controls.Add(this.VINLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditCarForm";
            this.Text = "Edit Car";
            this.Load += new System.EventHandler(this.EditCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BranchIDDropBox;
        private System.Windows.Forms.ComboBox CarTypeDropBox;
        private System.Windows.Forms.Button SubmitChangesButton;
        private System.Windows.Forms.Label BranchIDLabel;
        private System.Windows.Forms.Label CarTypeLabel;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox MakeBox;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.TextBox VINBox;
        private System.Windows.Forms.Label VINLabel;
    }
}