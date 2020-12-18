using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Car_Rental_Application
{
    public partial class MostRentedCarByDateForm : Form
    {
        public database datab;
        public main main;
        public MostRentedCarByDateForm(database temp, main form)
        {
            InitializeComponent();

            datab = temp;
            main = form;

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(StartDatePicker.Value.ToString("yyyy-MM-dd"));
            main.ReportsDGVMRC_LoadAll(datab, StartDatePicker.Value, EndDatePicker.Value);
            this.Close();
        }
    }
}
