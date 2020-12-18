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
    public partial class EditTransactionForm : Form
    {
        public database datab;
        public main main;

        public EditTransactionForm(database temp, main form)
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

            //ADD
            InEmployeeIDDropBox.Text = main.employeeSession;

        }

        private void EditTransactionForm_Load(object sender, EventArgs e)
        {
            TransactionIDBox.Text = this.getTransactionIDValue();
            CustomerIDDropBox.Text = this.getCustomerIDValue();
            VINDropBox.Text = this.getVINValue();
            DateOutPicker.Text = this.getDateOutValue();
            DateExpectedInPicker.Text = this.getDateExpectedInValue();
            DateInPicker.Text = this.getDateInValue();
            OutBranchIDDropBox.Text = this.getOutBranchValue();
            InBranchIDDropBox.Text = this.getInBranchValue();
            OutEmployeeIDDropBox.Text = this.getOutEmployeeValue();
            InEmployeeIDDropBox.Text = this.getInEmployeeValue();
            PaymentInformationBox.Text = this.getPaymentInformationValue();
            TotalBalanceBox.Text = this.getTotalBalanceValue();

            determineMemberStatus();
        }

        private void initializeSearchDates()
        //20190610TAG
        /* set initial search dates to current date */
        {
            DateOutPicker.Value = DateTime.Now;
            DateExpectedInPicker.Value = DateTime.Now;
        }

        private void EditTransactionButton_Click(object sender, EventArgs e)
            //20190610TAG 
            //20190611TAG
        {
            try
            {
                string command = "UPDATE RentalTransaction " + 
                                 "SET rID = " + TransactionIDBox.Text + ", " +
                                     "customerID = (SELECT cID FROM Customer WHERE name = '" + CustomerIDDropBox.Text + "'), " +
                                     "carID = '" + VINDropBox.Text + "', " +
                                     "dateOut = '" + DateOutPicker.Value.ToString("yyyy-MM-dd") + "', " +
                                     "dateIn = '" + DateInPicker.Value.ToString("yyyy-MM-dd") + "', " +
                                     "dateExpectedIn = '" + DateExpectedInPicker.Value.ToString("yyyy-MM-dd") + "', " +
                                     "branchOutID = (SELECT branchID FROM Branch WHERE branchName = '" + OutBranchIDDropBox.Text + "'), " +
                                     "branchInID = (SELECT branchID FROM Branch WHERE branchName = '" + InBranchIDDropBox.Text + "'), " +
                                     "employeeOutID = (SELECT eID FROM Employee WHERE name = '" + OutEmployeeIDDropBox.Text + "'), " +
                                     "employeeInID = (SELECT eID FROM Employee WHERE name = '" + InEmployeeIDDropBox.Text + "'), " +
                                     "paymentInformation = '" + PaymentInformationBox.Text + "' " +
                                     //"totalBalance = " + TotalBalanceBox.Text + 
                                 "WHERE rID = '" + TransactionIDBox.Text + "';";

                //calculate the regular daily rate
                command = command + "UPDATE RentalTransaction " +
                                  "SET totalBalance = (SELECT DATEDIFF(day, dateOut, dateIn)) *dailyRate " +
                                  "FROM RentalTransaction " +
                                  "JOIN Car ON RentalTransaction.carID = Car.VIN " +
                                  "JOIN CarType ON Car.cType = CarType.cType " +
                                  "JOIN Customer ON RentalTransaction.customerID = Customer.cID " +
                                  "LEFT JOIN MemberStatus on Customer.cID = MemberStatus.cID " +
                                  "WHERE rID = '" + TransactionIDBox.Text + "';";
                //
                //calculate the late fee if returned after expected date
                command = command + "UPDATE RentalTransaction " +
                                 "SET totalBalance = totalBalance + ((SELECT DATEDIFF(day, dateExpectedIn, dateIn)) *lateDailyRate) " +
                                 "FROM RentalTransaction " +
                                 "JOIN Car ON RentalTransaction.carID = Car.VIN " +
                                 "JOIN CarType ON Car.cType = CarType.cType " +
                                 "JOIN Customer ON RentalTransaction.customerID = Customer.cID " +
                                 "LEFT JOIN MemberStatus on Customer.cID = MemberStatus.cID " +
                                 "WHERE dateIn > dateExpectedIn " +
                                 "and rID = '" + TransactionIDBox.Text + "';";
                //
                //apply location penalty if returned at different location and not gold member
                command = command + "UPDATE RentalTransaction " +
                                    "SET totalBalance = totalBalance + penaltyRate " +
                                    "FROM RentalTransaction " +
                                    "JOIN Car ON RentalTransaction.carID = Car.VIN " +
                                    "JOIN CarType ON Car.cType = CarType.cType " +
                                    "JOIN Customer ON RentalTransaction.customerID = Customer.cID " +
                                    "WHERE NOT EXISTS(SELECT * FROM MemberStatus WHERE MemberStatus.cID = Customer.cID) and " +
                                    "RentalTransaction.branchInID != RentalTransaction.branchOutID " +
                                     "and rID = '" + TransactionIDBox.Text + "';";


                datab.insert(command);

                main.TransactionDGV_LoadAll(datab);
                this.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void EditTransactionButton_KeyPress(object sender, KeyPressEventArgs e)
        //20190611TAG
        /* listen for "enter" pressed on keyboard when edit transactoin field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                EditTransactionButton_Click(sender, e);
            }
        }

        private void determineMemberStatus()
        {
            // get current customer rental transaction for past year, check count
            int count = 0;
            string command = "SELECT count(rID) " +
                             "FROM RentalTransaction, " +
                                  "(SELECT * FROM Customer WHERE NOT EXISTS (SELECT cID FROM MemberStatus WHERE MemberStatus.cID = Customer.cID)) as C " + 
                             "WHERE C.cID = RentalTransaction.customerID and " +
                                   "C.name = '" + CustomerIDDropBox.Text + "' and " +
                                   "RentalTransaction.dateOut > '" + DateTime.Now.AddDays(-365) + "';";
            try
            {
                datab.query(command);

                while (datab.myReader.Read())
                {
                    count = int.Parse(datab.myReader[0].ToString());
                }

                datab.myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            // update to gold member status
            if (count >= 3) {
                try
                {
                    string updateCommand = "INSERT into MemberStatus values(" + "(SELECT cID FROM Customer WHERE name = '" + CustomerIDDropBox.Text + "')"+ ",'" + DateTime.Now + "');";
                    datab.insert(updateCommand);
                    main.TransactionDGV_LoadAll(datab);
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }

        /*---------------------------------------------------GET METHODS---------------------------------------------------*/
        //20190610TAG

        private string getTransactionIDValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[0].Value.ToString();
        }
        private string getCustomerIDValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[1].Value.ToString();
        }
        private string getVINValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[2].Value.ToString();
        }
        private string getDateOutValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[3].Value.ToString();
        }
        private string getDateExpectedInValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[5].Value.ToString();
        }
        private string getDateInValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[4].Value.ToString();
        }
        private string getOutBranchValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[6].Value.ToString();
        }
        private string getInBranchValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[7].Value.ToString();
        }
        private string getOutEmployeeValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[8].Value.ToString();
        }
        private string getInEmployeeValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[9].Value.ToString();
        }
        private string getPaymentInformationValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[10].Value.ToString();
        }
        private string getTotalBalanceValue()
        {
            var Cell = main.TransactionDGV.SelectedCells[0];
            return main.TransactionDGV.Rows[Cell.RowIndex].Cells[11].Value.ToString();
        }

        /*---------------------------------------------------GET METHODS---------------------------------------------------*/

    }
}
