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

    public partial class EditCarForm : Form
    {
        public database datab;
        public main main;

        // converts the string into something "System.Globalization" can manipulate?
        TextInfo text = CultureInfo.CurrentCulture.TextInfo;

        public EditCarForm(database temp, main form)
        {
            InitializeComponent();
            datab = temp;
            main = form;

            main.initializeCarTypeComboBox(datab, CarTypeDropBox);
            main.initializeBranchIDComboBox(datab, BranchIDDropBox);
            
            
        }

        // Load the original values of the data into the textbox
        private void EditCarForm_Load(object sender, EventArgs e)
        {
            VINBox.Text = this.getVINValue();
            MakeBox.Text = this.getMakeValue();
            ModelBox.Text = this.getModelValue();
            ColorBox.Text = this.getColorValue();
            CarTypeDropBox.Text = this.getcTypeValue();
            BranchIDDropBox.Text = this.getbIDValue();
        }

        private void SubmitChangesButton_Click(object sender, EventArgs e)
        {
            if (!main.isMakeValid(MakeBox.Text) && MakeBox.Text != "")
            {
                MessageBox.Show(MakeBox.Text + " is not a valid make", "Car Make Error");
                return;
            }

            /* Compare the corresponding input text to the value of the cell selected. If they are different update. If not, dont do anything*/
            try
            {
                // converts the string into something "System.Globalization" can manipulate?
                TextInfo text = CultureInfo.CurrentCulture.TextInfo;

                // Ensure the input text is not empty and different from the original value
                if (VINBox.Text != this.getVINValue() && !main.isEmpty(VINBox.Text))
                {
                    string updateVIN = "UPDATE Car SET VIN = '" + VINBox.Text.ToUpper() + "' WHERE VIN = '" + this.getVINValue() + "'";
                    datab.insert(updateVIN);
                }


                if (MakeBox.Text != this.getMakeValue() && !main.isEmpty(MakeBox.Text))
                {
                    string updateMake = "UPDATE Car SET make = '" + main.ProperMakeFormat(MakeBox) + "' WHERE make = '" + this.getMakeValue() + "' AND VIN ='" + VINBox.Text + "'";
                    datab.insert(updateMake);
                }


                if (ModelBox.Text != this.getModelValue() && !main.isEmpty(ModelBox.Text))
                {
                    string updateModel = "UPDATE Car SET model = '" + text.ToTitleCase(ModelBox.Text) + "' WHERE model = '" + this.getModelValue() + "' AND VIN ='" + VINBox.Text + "'";
                    datab.insert(updateModel);
                }

                if (ColorBox.Text != this.getColorValue() && !main.isEmpty(ColorBox.Text))
                {
                    string updateColor = "UPDATE Car SET color = '" + text.ToTitleCase(ColorBox.Text) + "' WHERE color = '" + this.getColorValue() + "' AND VIN ='" + VINBox.Text + "'";
                    datab.insert(updateColor);
                }

                if (CarTypeDropBox.Text != this.getcTypeValue() && !main.isEmpty(CarTypeDropBox.Text))
                {
                    string updatecType = "UPDATE Car SET cType = '" + main.ProperCarTypeFormat(CarTypeDropBox) + "' WHERE cType = '" + this.getcTypeValue() + "' AND VIN ='" + VINBox.Text + "'";
                    datab.insert(updatecType);
                }
                if (BranchIDDropBox.Text != this.getbIDValue() && !main.isEmpty(BranchIDDropBox.Text))
                {
                    string updatebID = "UPDATE Car SET branchID = '" + BranchIDDropBox.Text + "' WHERE branchID = '" + this.getbIDValue() + "' AND VIN ='" + VINBox.Text + "'";
                    datab.insert(updatebID);
                }

                main.CarsDGV_LoadAll(datab);
                this.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void editCar_KeyPress(object sender, KeyPressEventArgs e)
        /* listen for "enter" pressed on keyboard when edit car field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                SubmitChangesButton_Click(sender, e);
            }
        }

        /*---------------------------------------------------GET METHODS---------------------------------------------------*/
        // Returns the selected row's VIN value
        private string getVINValue()
        {
            var Cell = main.CarsDGV.SelectedCells[0];
            return main.CarsDGV.Rows[Cell.RowIndex].Cells[0].Value.ToString();
        }

        // Returns the selected row's make value
        private string getMakeValue()
        {
            var Cell = main.CarsDGV.SelectedCells[0];
            return main.CarsDGV.Rows[Cell.RowIndex].Cells[1].Value.ToString();
        }

        // Returns the selected row's model value
        private string getModelValue()
        {
            var Cell = main.CarsDGV.SelectedCells[0];
            return main.CarsDGV.Rows[Cell.RowIndex].Cells[2].Value.ToString();
        }

        // Returns the selected row's color value
        private string getColorValue()
        {
            var Cell = main.CarsDGV.SelectedCells[0];
            return main.CarsDGV.Rows[Cell.RowIndex].Cells[3].Value.ToString();
        }

        // Returns the selected row's car type value
        private string getcTypeValue()
        {
            var Cell = main.CarsDGV.SelectedCells[0];
            return main.CarsDGV.Rows[Cell.RowIndex].Cells[4].Value.ToString();
        }

        // Returns the selected row's branch ID value
        private string getbIDValue()
        {
            var Cell = main.CarsDGV.SelectedCells[0];
            return main.CarsDGV.Rows[Cell.RowIndex].Cells[5].Value.ToString();
        }

        /*---------------------------------------------------GET METHODS---------------------------------------------------*/
    }
}
