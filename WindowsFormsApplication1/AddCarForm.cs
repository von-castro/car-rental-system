using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;



namespace Car_Rental_Application
{
    public partial class AddCarForm : Form
    {
        public database datab;
        public main main;

        // converts the string into something "System.Globalization" can manipulate?
        TextInfo text = CultureInfo.CurrentCulture.TextInfo;

        public AddCarForm(database temp, main form)
        {

            InitializeComponent();

            datab = temp;
            main = form;

            main.initializeCarTypeComboBox(datab, CarTypeDropBox);
            main.initializeBranchIDComboBox(datab, BranchIDDropBox);

        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            // Error message if inputted text is not found in the ModelsList array
            if (!main.isMakeValid(MakeBox.Text) && MakeBox.Text != "")
            {
                MessageBox.Show(text.ToTitleCase(MakeBox.Text) + " is not a valid make", "Car Make Error");
                return;
            }

            try
            {
                // If any of the fields is empty
                if (main.isEmpty(VINBox.Text) || main.isEmpty(MakeBox.Text) || main.isEmpty(ModelBox.Text) ||
                    main.isEmpty(ColorBox.Text) || main.isEmpty(CarTypeDropBox.Text) || main.isEmpty(BranchIDDropBox.Text))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }

                // Proper make format variable
                string Make;

                // if 'bmw', 'gmc', or 'srt' is entered, make them all upper case
                if(MakeBox.Text.ToLower() == "bmw" || MakeBox.Text.ToLower() == "gmc"|| MakeBox.Text.ToLower() == "srt")
                {
                    Make = MakeBox.Text.ToUpper();
                }

                else
                {
                    Make = text.ToTitleCase(MakeBox.Text);
                }



                string command = "INSERT INTO Car VALUES('" + VINBox.Text.ToUpper() + "','" + main.ProperMakeFormat(MakeBox) + "','" + text.ToTitleCase(ModelBox.Text) + "','" +
                                                              text.ToTitleCase(ColorBox.Text) + "','" + main.ProperCarTypeFormat(CarTypeDropBox) + "'," + BranchIDDropBox.Text + ")";

                datab.insert(command);

                main.CarsDGV_LoadAll(datab);
                this.Close();
            }
            catch (Exception e2)
            {
                //  MessageBox.Show("VIN already exists in the system", "VIN Error");
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void addCar_KeyPress(object sender, KeyPressEventArgs e)
        /* listen for "enter" pressed on keyboard when edit car field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                AddCarButton_Click(sender, e);
            }
        }
    }
}
