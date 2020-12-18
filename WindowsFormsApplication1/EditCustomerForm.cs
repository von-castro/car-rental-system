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
    public partial class EditCustomerForm : Form
    {
        public database datab;
        public main main;

        // converts the string into something "System.Globalization" can manipulate?
        TextInfo text = CultureInfo.CurrentCulture.TextInfo;

        public EditCustomerForm(database temp, main form)
        {
            InitializeComponent();

            datab = temp;
            main = form;
        }

        private void SubmitChangesButton_Click(object sender, EventArgs e)
        {
            /* Compare the corresponding input text to the value of the cell selected. If they are different update. If not, dont do anything*/
            try
            {
                // converts the string into something "System.Globalization" can manipulate?
                TextInfo text = CultureInfo.CurrentCulture.TextInfo;

                // Ensure the input text is not empty and different from the original value
                if (CustomerIDBox.Text != this.getCustomerIDValue() && !main.isEmpty(CustomerIDBox.Text))
                {
                    string updatecID = "UPDATE Customer SET cID = '" + CustomerIDBox.Text + "' WHERE cID = '" + this.getCustomerIDValue() + "'";
                    datab.insert(updatecID);
                }


                if (DriversLicenseBox.Text != this.getDriverLicenseValue() && !main.isEmpty(DriversLicenseBox.Text))
                {
                    string updateDriversLicense = "UPDATE Customer SET driverLicense = '" + DriversLicenseBox.Text + "' WHERE driverLicense = '" + this.getDriverLicenseValue() + "' AND cID ='" + getCustomerIDValue() + "'";
                    datab.insert(updateDriversLicense);
                }


                if (NameBox.Text != this.getNameValue() && !main.isEmpty(NameBox.Text))
                {
                    string updateName = "UPDATE Customer SET name = '" + NameBox.Text + "' WHERE name = '" + this.getNameValue() + "' AND cID ='" + getCustomerIDValue() + "'";
                    datab.insert(updateName);
                }

                if (PhoneNumberBox.Text != this.getPhoneNumberValue() && !main.isEmpty(PhoneNumberBox.Text))
                {
                    string updatePhoneNumber = "UPDATE Customer SET phoneNumber = '" + PhoneNumberBox.Text + "' WHERE phoneNumber = '" + this.getPhoneNumberValue() + "' AND cID ='" + getCustomerIDValue() + "'";
                    datab.insert(updatePhoneNumber);
                }

                if (AddressBox.Text != this.getAddressValue() && !main.isEmpty(AddressBox.Text))
                {
                    string updateAddress = "UPDATE Customer SET address1 = '" + AddressBox.Text + "' WHERE address1 = '" + this.getAddressValue() + "' AND cID ='" + getCustomerIDValue() + "'";
                    datab.insert(updateAddress);
                }
                if (CityBox.Text != this.getCityValue() && !main.isEmpty(CityBox.Text))
                {
                    string updateCity = "UPDATE Customer SET city = '" + CityBox.Text + "' WHERE city = '" + this.getCityValue() + "' AND cID ='" + getCustomerIDValue() + "'";
                    datab.insert(updateCity);
                }

                if (ProvinceBox.Text != this.getProvinceValue() && !main.isEmpty(ProvinceBox.Text))
                {
                    string updateProvince = "UPDATE Customer SET province = '" + ProvinceBox.Text + "' WHERE province = '" + this.getProvinceValue() + "' AND cID ='" + getCustomerIDValue() + "'";
                    datab.insert(updateProvince);
                }
                if (PostalCodeBox.Text != this.getPostalCodeValue() && !main.isEmpty(PostalCodeBox.Text))
                {
                    string updatePostalCode = "UPDATE Customer SET postCode = '" + PostalCodeBox.Text + "' WHERE postCode = '" + this.getPostalCodeValue() + "' AND cID ='" + getCustomerIDValue() + "'";
                    datab.insert(updatePostalCode);
                }

                main.CustomersDGV_LoadAll(datab);
                this.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }


        // Load the original values of the data into the textbox
        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            CustomerIDBox.Text = this.getCustomerIDValue();
            DriversLicenseBox.Text = this.getDriverLicenseValue();
            NameBox.Text = this.getNameValue();
            PhoneNumberBox.Text = this.getPhoneNumberValue();
            AddressBox.Text = this.getAddressValue();
            CityBox.Text = this.getCityValue();
            ProvinceBox.Text = this.getProvinceValue();
            PostalCodeBox.Text = this.getPostalCodeValue();
        }

        private void editCustomer_KeyPress(object sender, KeyPressEventArgs e)
        /* listen for "enter" pressed on keyboard when edit car field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                SubmitChangesButton_Click(sender, e);
            }
        }
        /*---------------------------------------------------GET METHODS---------------------------------------------------*/
        // Returns the selected row's Customer value
        private string getCustomerIDValue()
        {
            var Cell = main.CustomersDGV.SelectedCells[0];
            return main.CustomersDGV.Rows[Cell.RowIndex].Cells[1].Value.ToString();
        }

        // Returns the selected row's Drivers License value
        private string getDriverLicenseValue()
        {
            var Cell = main.CustomersDGV.SelectedCells[0];
            return main.CustomersDGV.Rows[Cell.RowIndex].Cells[2].Value.ToString();
        }

        // Returns the selected row's Name value
        private string getNameValue()
        {
            var Cell = main.CustomersDGV.SelectedCells[0];
            return main.CustomersDGV.Rows[Cell.RowIndex].Cells[3].Value.ToString();
        }

        // Returns the selected row's Phone Number value
        private string getPhoneNumberValue()
        {
            var Cell = main.CustomersDGV.SelectedCells[0];
            return main.CustomersDGV.Rows[Cell.RowIndex].Cells[4].Value.ToString();
        }

        // Returns the selected row's Address value
        private string getAddressValue()
        {
            var Cell = main.CustomersDGV.SelectedCells[0];
            return main.CustomersDGV.Rows[Cell.RowIndex].Cells[5].Value.ToString();
        }

        // Returns the selected row's City value
        private string getCityValue()
        {
            var Cell = main.CustomersDGV.SelectedCells[0];
            return main.CustomersDGV.Rows[Cell.RowIndex].Cells[6].Value.ToString();
        }

        // Returns the selected row's Province value
        private string getProvinceValue()
        {
            var Cell = main.CustomersDGV.SelectedCells[0];
            return main.CustomersDGV.Rows[Cell.RowIndex].Cells[7].Value.ToString();
        }

        // Returns the selected row's Postal Code value
        private string getPostalCodeValue()
        {
            var Cell = main.CustomersDGV.SelectedCells[0];
            return main.CustomersDGV.Rows[Cell.RowIndex].Cells[8].Value.ToString();
        }

        /*---------------------------------------------------GET METHODS---------------------------------------------------*/
    }
}
