using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Application
{
    public partial class RentalHistoryByCustomerForm : Form
    {
        public database datab;
        public main main;
        public RentalHistoryByCustomerForm(database temp, main form)
        {
            InitializeComponent();

            datab = temp;
            main = form;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            main.ReportsDGVRHC_LoadAll(datab, StartDatePicker.Value, EndDatePicker.Value, CustomerNameBox.Text);
            this.Close();
        }
    }
}
