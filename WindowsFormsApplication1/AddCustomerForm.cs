using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Car_Rental_Application
{
    public partial class AddCustomerForm : Form
    {
        public database datab;
        public main main;

        // converts the string into something "System.Globalization" can manipulate?
        TextInfo text = CultureInfo.CurrentCulture.TextInfo;

        public AddCustomerForm(database temp, main form)
        {
            InitializeComponent();

            datab = temp;
            main = form;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // If any of the fields is empty
                if (main.isEmpty(CustomerIDBox.Text) || main.isEmpty(DriversLicenseBox.Text) || main.isEmpty(NameBox.Text) ||
                    main.isEmpty(PhoneNumberBox.Text) || main.isEmpty(AddressBox.Text) || main.isEmpty(CityBox.Text) ||
                    main.isEmpty(ProvinceBox.Text) || main.isEmpty(PostalCodeBox.Text))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }

                string command = "INSERT INTO Customer VALUES('" + CustomerIDBox.Text + "','" + DriversLicenseBox.Text.ToUpper() + "','" + text.ToTitleCase(NameBox.Text) + "','" +
                                                              PhoneNumberBox.Text + "','" + text.ToTitleCase(AddressBox.Text) + "','" + text.ToTitleCase(CityBox.Text) + "','" +
                                                              text.ToTitleCase(ProvinceBox.Text) + "','" + PostalCodeBox.Text.ToUpper()+"')";

                datab.insert(command);

                main.CustomersDGV_LoadAll(datab);
                this.Close();
            }
            catch (Exception e2)
            {
                //  MessageBox.Show("VIN already exists in the system", "VIN Error");
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void addCustomer_KeyPress(object sender, KeyPressEventArgs e)
        /* listen for "enter" pressed on keyboard when edit car field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                AddCustomerButton_Click(sender, e);
            }
        }
    }
}
