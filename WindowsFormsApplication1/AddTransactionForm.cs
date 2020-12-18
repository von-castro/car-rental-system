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
    public partial class AddTransactionForm : Form
    {
        public database datab;
        public main main;

        // converts the string into something "System.Globalization" can manipulate
        TextInfo text = CultureInfo.CurrentCulture.TextInfo;

        public AddTransactionForm(database temp, main form)
            //20190610TAG
            //20190611TAG
        {
            InitializeComponent();

            datab = temp;
            main = form;

            main.initializeCustomerNameComboBox(datab, CustomerIDDropBox);
            main.initializeBranchNameComboBox(datab, OutBranchIDDropBox);
            main.initializeBranchNameComboBox(datab, InBranchIDDropBox);
            main.initializeEmployeeNameComboBox(datab, OutEmployeeIDDropBox);
            main.initializeEmployeeNameComboBox(datab, InEmployeeIDDropBox);
            initializeSearchDates();
            initializeTransactionID();

            //ADD
            OutEmployeeIDDropBox.Text = main.employeeSession;
        }

        private void initializeTransactionID()
            //20190611TAG
        {
            TransactionIDBox.Text = main.GetNextID(datab).ToString();
        }

        private void initializeSearchDates()
            //20190610TAG
            //20190611TAG
        /* set initial search dates to current date */
        {
            DateOutPicker.Value = DateTime.Now;
            DateExpectedInPicker.Value = DateTime.Now;
            DateInPicker.Value = DateTime.Now;
        }

        private void VINDropBox_Enter(object sender, EventArgs e)
        // get list of cars available for date range selected
        // 20190610TAG
        {
            string start = DateOutPicker.Value.ToString("yyyy-MM-dd");
            string end = DateExpectedInPicker.Value.ToString("yyyy-MM-dd");
            string command = "select car.VIN " +
                  "from car " +
                  "where " +
                        "NOT EXISTS " +
                        "(select carid " +
                        "from rentaltransaction " +
                        "where car.vin = rentaltransaction.carid and '" + start + "' BETWEEN rentaltransaction.dateout and rentaltransaction.dateexpectedin) " +
                  "and " +
                        "NOT EXISTS " +
                        "(select carid " +
                        "from rentaltransaction " +
                        "where car.vin = rentaltransaction.carid and '" + end + "' BETWEEN rentaltransaction.dateout and rentaltransaction.dateexpectedin)" +
                  "and " +
                        "NOT EXISTS " +
                        "(select carid " +
                        "from rentaltransaction " +
                        "where car.vin = rentaltransaction.carid and '" + start + "' < rentaltransaction.dateout and '" + end + "' > rentaltransaction.dateexpectedin)";

            try
            {
                datab.query(command);
                VINDropBox.Items.Clear();

                while (datab.myReader.Read())
                {
                    VINDropBox.Items.Add(datab.myReader[0]);
                }

                if (VINDropBox.Items.Count == 0)
                {
                    VINDropBox.Items.Add("No cars available - try different dates");
                }

                datab.myReader.Close();
            }

            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        

        private void AddTransactionButton_Click(object sender, EventArgs e)
            //20190610TAG
            //TODO need to be able to add transaction and still have branchIn and employeeIn boxes empty
        {
            if (TransactionIDBox.Text == ""     || main.isEmpty(TransactionIDBox.Text) || 
                CustomerIDDropBox.Text == ""    || main.isEmpty(CustomerIDDropBox.Text) || 
                VINDropBox.Text == ""           || main.isEmpty(VINDropBox.Text) || 
                OutBranchIDDropBox.Text == ""   || main.isEmpty(OutBranchIDDropBox.Text) || 
                //InBranchIDDropBox.Text == ""    || main.isEmpty(InBranchIDDropBox.Text) || 
                OutEmployeeIDDropBox.Text == "" || main.isEmpty(OutEmployeeIDDropBox.Text) ||
                //InEmployeeIDDropBox.Text == ""  || main.isEmpty(InEmployeeIDDropBox.Text) || 
                PaymentInformationBox.Text == ""|| main.isEmpty(PaymentInformationBox.Text)) //|| 
                //TotalBalanceBox.Text == ""      || main.isEmpty(TotalBalanceBox.Text))
            {
                MessageBox.Show("Please ensure all fields are filled", "Empty Field!");
                return;
            }

            if (VINDropBox.Text == "No cars available - try different dates")
            {
                MessageBox.Show("Please change date range to select an available car", "Message");
                return;
            }

            try
            {
                string command = "INSERT INTO RentalTransaction VALUES('" + TransactionIDBox.Text + "', (SELECT cID FROM Customer WHERE name = '" + CustomerIDDropBox.Text + "'),'" + VINDropBox.Text + "','" +
                                                              DateOutPicker.Value.ToString("yyyy-MM-dd") +"'," + "NULL" +  ",'" + DateExpectedInPicker.Value.ToString("yyyy-MM-dd") + 
                                                              "', (SELECT branchID FROM Branch WHERE branchName = '" + OutBranchIDDropBox.Text + "'), (SELECT branchID FROM Branch WHERE branchName = '" + InBranchIDDropBox.Text + "')," +
                                                              "(SELECT eID FROM Employee WHERE name = '" + OutEmployeeIDDropBox.Text + "'), (SELECT eID FROM Employee WHERE name = '" + InEmployeeIDDropBox.Text + "'),'" + 
                                                              PaymentInformationBox.Text + "','" + TotalBalanceBox.Text + "')";

                datab.insert(command);

                main.TransactionDGV_LoadAll(datab);
                this.Close();
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void AddTransactionButton_KeyPress(object sender, KeyPressEventArgs e)
        //20190611TAG
        /* listen for "enter" pressed on keyboard when add transactoin field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                AddTransactionButton_Click(sender, e);
            }
        }

    }
}
;