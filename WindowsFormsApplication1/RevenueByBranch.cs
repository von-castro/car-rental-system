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
    public partial class RevenueByBranchForm : Form
    {
        public database datab;
        public main main;

        public RevenueByBranchForm(database temp, main form)
        {
            InitializeComponent();

            datab = temp;
            main = form;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            main.ReportsDGVRBB_LoadAll(datab, StartDatePicker.Value, EndDatePicker.Value);
            this.Close();
        }
    }
}
