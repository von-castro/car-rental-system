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
    public partial class main : Form
    {
        public database datab;
        public DateTime start;
        public DateTime end;
        public string employeeSession;
        private static readonly Random getrandom = new Random();

        // converts the string into something "System.Globalization" can manipulate?
        TextInfo text = CultureInfo.CurrentCulture.TextInfo;
        public main()
        {
            InitializeComponent();
            datab = new database();
            initializeSplashEmployeeComboBox(datab);

            HomeDGV_LoadAll();
        }
        /*____________________________________________________Log In Screen____________________________________________________*/
        private void EmployeeLogInButton_Click(object sender, EventArgs e)
        {
            if (isEmpty(splashEmployeeComboBox.Text)){
                MessageBox.Show("Please select an employee name", "Employee Error");
                return;
            }
            EmployeePanelLogIn.Visible = false;
            username.Text = splashEmployeeComboBox.Text;
            employeeSession = username.Text;
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            username.Text = "";
            EmployeePanelLogIn.Visible = true;
            HomeButton.PerformClick();

        }
        /*____________________________________________________Log In Screen____________________________________________________*/

        /*____________________________________________________Left Panel Buttons____________________________________________________*/
        private void CarsButton_Click(object sender, EventArgs e)
        {
            Highlight_Selection(CarsButton);
            Load_CarScreen();
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            Highlight_Selection(TransactionsButton);
            Load_TransactionScreen();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            Highlight_Selection(ReportsButton);
            Load_ReportsScreen();
        }

        private void CustomersButton_Click_1(object sender, EventArgs e)
        {
            Highlight_Selection(CustomersButton);
            Load_CustomerScreen();
            Customers_Update_MemberStatus();
            //CustomersDGV.Refresh();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Highlight_Selection(HomeButton);
            Load_HomeScreen();
        }

        /*____________________________________________________Left Panel Buttons____________________________________________________*/


        /*____________________________________________________Potentially useful methods____________________________________________________*/
        private void Load_HomeScreen()
        {
            CarsPanelDGV.Visible = false;
            CarsPanelButtons.Visible = false;

            TransactionPanelDGV.Visible = false;
            TransactionPanelButtons.Visible = false;

            CustomersPanelDGV.Visible = false;
            CustomersPanelButtons.Visible = false;

            this.Width = 1170;
            HomeDGV_LoadAll();
            HomePanelDGV.Visible = true;
            HomePanelButtons.Visible = true;

        }

        private void Load_CustomerScreen()
        {
            CarsPanelDGV.Visible = false;
            CarsPanelButtons.Visible = false;

            TransactionPanelDGV.Visible = false;
            TransactionPanelButtons.Visible = false;

            HomePanelDGV.Visible = false;
            HomePanelButtons.Visible = false;

            this.Width = 1170;
            CustomersDGV_LoadAll(datab);
            CustomersPanelDGV.Visible = true;
            CustomersPanelButtons.Visible = true;

        }

        //private int isGoldMember(ssdasdasd)
        //{
        //    return int;
        //}

        private void Customers_Update_MemberStatus()
        {
            
            for (int i = 0; i < CustomersDGV.Rows.Count; i++)
            {
                if (String.IsNullOrEmpty(CustomersDGV[9, i].Value.ToString()))
                {
                    //MessageBox.Show("MemberSince is Empty", "Test");
                    CustomersDGV[0, i].Value = "Regular";
                }
                else
                {
                    CustomersDGV[0, i].Value = "Gold";
                }
            }
        }

        private void Load_CarScreen()
        {
            HomePanelDGV.Visible = false;
            HomePanelButtons.Visible = false;

            TransactionPanelDGV.Visible = false;
            TransactionPanelButtons.Visible = false;

            CustomersPanelDGV.Visible = false;
            CustomersPanelButtons.Visible = false;

            this.Width = 1170;
            CarsDGV_LoadAll(datab);
            CarsPanelDGV.Visible = true;
            CarsPanelButtons.Visible = true;
            
        }

        private void Load_TransactionScreen()
        {
            
            CarsPanelDGV.Visible = false;
            CarsPanelButtons.Visible = false;

            HomePanelDGV.Visible = false;
            HomePanelButtons.Visible = false;

            CustomersPanelDGV.Visible = false;
            CustomersPanelButtons.Visible = false;
            this.Width = 1400;
            //this.Height = 800;
            TransactionDGV_LoadAll(datab);
            TransactionPanelDGV.Visible = true;
            TransactionPanelButtons.Visible = true;
            


        }

        private void Load_ReportsScreen()
        {
            CarsPanelDGV.Visible = false;
            CarsPanelButtons.Visible = false;

            HomePanelDGV.Visible = false;
            HomePanelButtons.Visible = false;

            CustomersPanelDGV.Visible = false;
            CustomersPanelButtons.Visible = false;

            TransactionPanelDGV.Visible = false;
            TransactionPanelButtons.Visible = false;

            this.Width = 1170;
            ReportsPanelDGV.Visible = true;
            ReportsPanelButtons.Visible = true;

        }

        // Panel created to highlight the selection of the buttons
        private void Highlight_Selection(Button Screen)
        {
            // Reposition the panel to a position that indicates which button was selected
            HighlightLeftSelection.Height = Screen.Height;
            HighlightLeftSelection.Top = Screen.Top;
        }

        // If a cell click is made, select the row where the cell resides in
        private void CellSelectToRowSelect(DataGridView DGV, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int index = e.RowIndex;
            DGV.Rows[index].Selected = true;
        }

        internal String ProperMakeFormat(TextBox makeText)
        {
            // if 'bmw', 'gmc', or 'srt' is entered, make them al upper case
            if (makeText.Text.ToLower() == "bmw" || makeText.Text.ToLower() == "gmc" || makeText.Text.ToLower() == "srt")
            {
                return makeText.Text.ToUpper();
            }

            else
            {
                return text.ToTitleCase(makeText.Text);
            }
        }

        internal String ProperCarTypeFormat(ComboBox CarTypeText)
        {
            // if 'bmw', 'gmc', or 'srt' is entered, make them al upper case
            if (CarTypeText.Text.ToLower() == "suv")
            {
                return CarTypeText.Text.ToUpper();
            }

            else
            {
                return text.ToTitleCase(CarTypeText.Text);
            }
        }

        public void isValid_BranchID(String text)
        {
            try
            {
                string command = "SELECT DISTINCT cType FROM CarType ORDER BY cType ASC";

                datab.query(command);

                while (datab.myReader.Read())
                {

                }
                datab.myReader.Close();
            }
            catch(Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        public void initializeCarTypeComboBox(database temp, ComboBox dropbox)
        {
            try
            {
                string command = "SELECT DISTINCT cType FROM CarType ORDER BY cType ASC";
                datab = temp;
                datab.query(command);

                while (datab.myReader.Read())
                {
                    dropbox.Items.Add(datab.myReader[0]);
                }
                datab.myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        private void initializeSplashEmployeeComboBox(database temp)
        /* get the list of employees to populate login splash screen */
        {
            try
            {
                string command = "SELECT DISTINCT name FROM Employee ORDER BY name ASC";
                datab = temp;
                datab.query(command);

                while (datab.myReader.Read())
                {
                    splashEmployeeComboBox.Items.Add(datab.myReader[0]);
                }

                datab.myReader.Close();
            }

            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        public void initializeBranchNameComboBox(database temp, ComboBox dropbox)
        //20190611AG
        {
            try
            {
                string command = "SELECT DISTINCT BranchName FROM Branch ORDER BY BranchName ASC";
                datab = temp;
                datab.query(command);

                while (datab.myReader.Read())
                {
                    dropbox.Items.Add(datab.myReader[0]);
                }
                datab.myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }
        public void initializeCustomerNameComboBox(database temp, ComboBox dropbox)
        //20190611TAG
        {
            try
            {
                string command = "SELECT DISTINCT name FROM Customer ORDER BY name ASC";
                datab = temp;
                datab.query(command);

                while (datab.myReader.Read())
                {
                    dropbox.Items.Add(datab.myReader[0]);
                }
                datab.myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }
        public void initializeEmployeeNameComboBox(database temp, ComboBox dropbox)
        //20190611TAG
        {
            try
            {
                string command = "SELECT DISTINCT name FROM Employee ORDER BY name ASC";
                datab = temp;
                datab.query(command);

                while (datab.myReader.Read())
                {
                    dropbox.Items.Add(datab.myReader[0]);
                }
                datab.myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        public void initializeBranchIDComboBox(database temp, ComboBox dropbox)
        {
            try
            {
                string command = "SELECT DISTINCT BranchID FROM Branch ORDER BY BranchID ASC";
                datab = temp;
                datab.query(command);

                while (datab.myReader.Read())
                {
                    dropbox.Items.Add(datab.myReader[0]);
                }
                datab.myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        public void initializeAvailableVINComboBox(database temp, ComboBox dropbox, DateTime start, DateTime end)
        {
            string startDate = start.ToString("yyyy-MM-dd");
            string endDate = end.ToString("yyyy-MM-dd");
            // first select all cars, then check if the selected pick up date or selected drop off date fall within any existing rental transactions
            // if those dates fall within existing rental transaction, then the car is not available for selected dates and should be excluded from query results
            string command = "select * " +
                              "from car, cartype, branch " +
                              "where car.ctype = cartype.ctype and car.branchid = branch.branchid and " +
                                    "NOT EXISTS " +
                                    "(select carid " +
                                    "from rentaltransaction " +
                                    "where car.vin = rentaltransaction.carid and '" + start + "' BETWEEN rentaltransaction.dateout and rentaltransaction.dateexpectedin) " +
                              "and " +
                                    "NOT EXISTS " +
                                    "(select carid " +
                                    "from rentaltransaction " +
                                    "where car.vin = rentaltransaction.carid and '" + end + "' BETWEEN rentaltransaction.dateout and rentaltransaction.dateexpectedin)";
            try
            {
                datab.query(command);

                HomeDGV.Rows.Clear();
                while (datab.myReader.Read())
                {
                    HomeDGV.Rows.Add(
                        datab.myReader["VIN"].ToString(),
                        datab.myReader["Make"].ToString(),
                        datab.myReader["Model"].ToString(),
                        datab.myReader["Color"].ToString(),
                        datab.myReader["DailyRate"].ToString(),
                        datab.myReader["BranchName"].ToString());
                }

                datab.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        public void initializeEmployeeIDComboBox(database temp, ComboBox dropbox)
        {
            try
            {
                string command = "SELECT DISTINCT eID FROM Employee ORDER BY eID ASC";
                datab = temp;
                datab.query(command);

                while (datab.myReader.Read())
                {
                    dropbox.Items.Add(datab.myReader[0]);
                }
                datab.myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        public void initializeCustomerIDComboBox(database temp, ComboBox dropbox)
        {
            try
            {
                string command = "SELECT DISTINCT cID FROM Customer ORDER BY cID ASC";
                datab = temp;
                datab.query(command);

                while (datab.myReader.Read())
                {
                    dropbox.Items.Add(datab.myReader[0]);
                }
                datab.myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        public bool isEmpty(String text)
        {
            return (text == "" || char.IsWhiteSpace(text, 0));
        }

        //public static int GetRandomNumber(database temp, String PrimaryKeyLabel, String Table)
        //{
        //    try
        //    {
        //        lock (getrandom) // synchronize
        //        {
        //            int RandomNum = getrandom.Next();
        //            string command = "SELECT " + PrimaryKeyLabel + " FROM " + Table + " WHERE " + PrimaryKeyLabel + " = ";

        //            return RandomNum;
        //        }
               
        //        return 0;
        //    }
        //    catch(Exception e)
        //    {
        //        MessageBox.Show(e.ToString(), "Error");
        //    }
        //}

        private void isVINValid(String VIN)
        {
                   
        }

        /*____________________________________________________Potentially useful methods____________________________________________________*/


        /*____________________________________________________Home Screen____________________________________________________*/


        /*+++++++++++++++++++++++++++++++++++++++++++++Home Panel Buttons+++++++++++++++++++++++++++++++++++++++++++++++*/


        private void resultsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellSelectToRowSelect(HomeDGV, e);
        }

        private void HomeShowAllButton_Click(object sender, EventArgs e)
        {
            HomeDGV_LoadAll();
        }
        /*+++++++++++++++++++++++++++++++++++++++++++++Home Panel Buttons+++++++++++++++++++++++++++++++++++++++++++++++*/

        /*+++++++++++++++++++++++++++++++++++++++++++++Home Screen Methods+++++++++++++++++++++++++++++++++++++++++++++++*/
        private void HomeDGV_LoadAll()
        {
            // Select all cars
            string command = "select * " +
                              "from car, cartype, branch " +
                              "where car.ctype = cartype.ctype and car.branchid = branch.branchid";
            try
            {
                datab.query(command);

                HomeDGV.Rows.Clear();
                while (datab.myReader.Read())
                {
                    HomeDGV.Rows.Add(
                        datab.myReader["VIN"].ToString(),
                        datab.myReader["Make"].ToString(),
                        datab.myReader["Model"].ToString(),
                        datab.myReader["Color"].ToString(),
                        datab.myReader["DailyRate"].ToString(),
                        datab.myReader["BranchName"].ToString());
                }

                datab.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void HomeDGV_LoadAvailable(object sender, EventArgs e)
        //20190610TAG
        {
            string startDate = pickupDate.Value.ToString("yyyy-MM-dd");
            string endDate = dropoffDate.Value.ToString("yyyy-MM-dd");
            // first select all cars, then check if the selected pick up date or selected drop off date fall within any existing rental transactions
            // if those dates fall within existing rental transaction, then the car is not available for selected dates and should be excluded from query results
            string command = "select * " +
                              "from car, cartype, branch " +
                              "where car.ctype = cartype.ctype and car.branchid = branch.branchid and " +
                                    "NOT EXISTS " +
                                    "(select carid " +
                                    "from rentaltransaction " +
                                    "where car.vin = rentaltransaction.carid and '" + startDate + "' BETWEEN rentaltransaction.dateout and rentaltransaction.dateexpectedin) " +
                              "and " +
                                    "NOT EXISTS " +
                                    "(select carid " +
                                    "from rentaltransaction " +
                                    "where car.vin = rentaltransaction.carid and '" + endDate + "' BETWEEN rentaltransaction.dateout and rentaltransaction.dateexpectedin)" +
                              "and " +
                                    "NOT EXISTS " +
                                    "(select carid " +
                                    "from rentaltransaction " +
                                    "where car.vin = rentaltransaction.carid and '" + startDate + "' < rentaltransaction.dateout and '" + endDate + "' > rentaltransaction.dateexpectedin)";
            try
            {
                datab.query(command);

                HomeDGV.Rows.Clear();
                while (datab.myReader.Read())
                {
                    HomeDGV.Rows.Add(
                        datab.myReader["VIN"].ToString(),
                        datab.myReader["Make"].ToString(),
                        datab.myReader["Model"].ToString(),
                        datab.myReader["Color"].ToString(),
                        datab.myReader["DailyRate"].ToString(),
                        datab.myReader["BranchName"].ToString());
                }

                datab.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void initializeSearchDates()
        /* set initial search dates to current date */
        {
            pickupDate.Value = DateTime.Now;
            dropoffDate.Value = DateTime.Now;
        }
        /*+++++++++++++++++++++++++++++++++++++++++++++Home Screen Methods+++++++++++++++++++++++++++++++++++++++++++++++*/

        /*____________________________________________________Home Screen____________________________________________________*/


        /*____________________________________________________Customer Screen____________________________________________________*/

        /*+++++++++++++++++++++++++++++++++++++++++++++Customer Panel Buttons+++++++++++++++++++++++++++++++++++++++++++++++*/
        private void CustomersAddButton_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2(datab);
            add.ShowDialog();
            CustomersDGV_LoadAll(datab);
            Customers_Update_MemberStatus();
        }

        private void CustomersDeleteButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(("Deleting a Customer will delete its transaction records. Are you sure you want to delete?"), "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                // As Long as there is a row to select loop
                for (int i = 0; i < CustomersDGV.Rows.Count; i++)
                {
                    // Selected row to be deleted
                    DataGridViewRow deleteRow = CustomersDGV.Rows[i];

                    if (deleteRow.Selected == true)
                    {
                        try
                        {
                            string selectedRow = CustomersDGV[1, i].Value.ToString();
                            string MemberStatusDelete = "DELETE FROM MemberStatus WHERE cID = '" + selectedRow + "'";
                            datab.insert(MemberStatusDelete);

                            
                            string command = "DELETE FROM Customer WHERE cID = '" + selectedRow + "'";
                            //CustomersDGV.Rows.RemoveAt(i);

                            // Remove the row from the database
                            datab.insert(command);
                            MessageBox.Show("Customer ID: " + selectedRow + " successfully deleted");

                            // Remove the row from the cars dgv
                            CustomersDGV.Rows.RemoveAt(i);

                            // Refreshes the DGV
                            //CarsDGV_LoadAll(datab);
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }
        

        private void CustomersEditButton_Click(object sender, EventArgs e)
        {
            EditCustomerForm edit = new EditCustomerForm(datab, this);
            edit.ShowDialog();
            Customers_Update_MemberStatus();
        }

        private void CustomersSearchButton_Click(object sender, EventArgs e)
        {
            string command = "SELECT DISTINCT Customer.cID as 'Customer ID', driverLicense AS 'Drivers License', name AS Name,  phoneNumber AS 'Phone Number', address1 AS Address, " +
                "city AS City, province AS Province, postCode AS 'Postal Code', MemberStatus.sinceDate as 'Member Since'" +
                "FROM Customer " + 
                "LEFT JOIN MemberStatus " +
                "ON Customer.cID = MemberStatus.cID WHERE Customer.cID = '" + CustomersSearchBox.Text + "'";
            if (isEmpty(CustomersSearchBox.Text))
            {
                CustomersShowAllButton.PerformClick();
                return;
            }
           
            try
            {

                datab.query(command);
                //CustomersDGV.Rows.Clear();
                //while (datab.myReader.Read())
                //{
                //    CustomersDGV.Rows.Add(datab.myReader["cID"].ToString(), datab.myReader["driverLicense"].ToString(), datab.myReader["name"].ToString(),
                //              datab.myReader["phoneNumber"].ToString(), datab.myReader["address1"].ToString(), datab.myReader["city"].ToString(),
                //              datab.myReader["province"].ToString(), datab.myReader["postCode"].ToString());
                //}
                //datab.myReader.Close();

                DataTable temp = new DataTable();
                temp.Load(datab.myReader);
                CustomersDGV.DataSource = temp;
                datab.myReader.Close();
                Customers_Update_MemberStatus_Single();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

        }

        private void CustomersShowAllButton_Click(object sender, EventArgs e)
        {
            CustomersDGV_LoadAll(datab);
            Customers_Update_MemberStatus();
        }

        private void CustomersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellSelectToRowSelect(CustomersDGV, e);
        }

        private void CustomersDGV_CellDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            CellSelectToRowSelect(CustomersDGV, e);
            EditCustomerForm edit = new EditCustomerForm(datab, this);
            edit.ShowDialog();
        }

        private void CustomersSearch_KeyPress(object sender, KeyPressEventArgs e)
        /* listen for "enter" pressed on keyboard when edit car field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                CustomersSearchButton_Click(sender, e);
            }
        }
        /*+++++++++++++++++++++++++++++++++++++++++++++Customer Panel Buttons+++++++++++++++++++++++++++++++++++++++++++++++*/

        /*+++++++++++++++++++++++++++++++++++++++++++++Customer Screen Methods+++++++++++++++++++++++++++++++++++++++++++++++*/
        private void Customers_Update_MemberStatus_Single()
        {
            if (CustomersDGV.Rows.Count == 0)
            {
                return;
            }

            if (String.IsNullOrEmpty(CustomersDGV[9, 0].Value.ToString()))
            {
               CustomersDGV[0, 0].Value = "Regular";
            }
            else
            {
               CustomersDGV[0, 0].Value = "Gold";
            }
            
            
            //for (int i = 0; i < CustomersDGV.Rows.Count; i++)
            //{
            //    if (String.IsNullOrEmpty(CustomersDGV[9, i].Value.ToString()))
            //    {
            //        //MessageBox.Show("MemberSince is Empty", "Test");
            //        CustomersDGV[0, i].Value = "Regular";
            //    }
            //    else
            //    {
            //        CustomersDGV[0, i].Value = "Gold";
            //    }
            //}
        }
        public void CustomersDGV_LoadAll(database datab)
        {
            // Query to obtain all customers in the dataset
            datab.query("SELECT DISTINCT Customer.cID as 'Customer ID', driverLicense AS 'Drivers License', name AS Name,  phoneNumber AS 'Phone Number', address1 AS Address, " +
                "city AS City, province AS Province, postCode AS 'Postal Code', MemberStatus.sinceDate as 'Member Since'" +
                "FROM Customer " +
                "LEFT JOIN MemberStatus " +
                "ON Customer.cID = MemberStatus.cID");

            // Refresh cars in the dgv
            //CustomersDGV.Rows.Clear();
            //while (datab.myReader.Read())
            //{
            //    CustomersDGV.Rows.Add(datab.myReader["cID"].ToString(), datab.myReader["driverLicense"].ToString(), datab.myReader["name"].ToString(),
            //                  datab.myReader["phoneNumber"].ToString(), datab.myReader["address1"].ToString(), datab.myReader["city"].ToString(),
            //                  datab.myReader["province"].ToString(), datab.myReader["postCode"].ToString());
            //}
            DataTable temp = new DataTable();

           
            temp.Load(datab.myReader);
            CustomersDGV.DataSource = temp;
            datab.myReader.Close();
        }
        /*+++++++++++++++++++++++++++++++++++++++++++++Customer Screen Methods+++++++++++++++++++++++++++++++++++++++++++++++*/

        /*____________________________________________________Customer Screen____________________________________________________*/


        /*____________________________________________________Car Screen____________________________________________________*/

        /*+++++++++++++++++++++++++++++++++++++++++++++Cars Panel Buttons+++++++++++++++++++++++++++++++++++++++++++++++*/

        private void CarsAddButton_Click(object sender, EventArgs e)
        {
            AddCarForm add = new AddCarForm(datab, this);
            add.ShowDialog();
        }

        private void CarsDeleteButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(("Deleting a car will delete its transaction records. Are you sure you want to delete?" ), "Confirm", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                // As Long as there is a row to select loop
                for (int i = 0; i < CarsDGV.Rows.Count; i++)
                {
                    // Selected row to be deleted
                    DataGridViewRow deleteRow = CarsDGV.Rows[i];

                    if (deleteRow.Selected == true)
                    {
                        try
                        {
                            // Grab the value of the VIN in the selected row for query
                            string selectedRow = CarsDGV[0, i].Value.ToString();
                            string command = //"ALTER TABLE [RentalTransaction] NOCHECK CONSTRAINT ALL "+
                                             "DELETE FROM Car WHERE VIN = '" + selectedRow + "' "; //+
                                                                                                   //"ALTER TABLE [RentalTransaction] WITH CHECK CHECK CONSTRAINT ALL";

                            string command2 = "DELETE FROM RentalTransaction WHERE carID = '" + CarsDGV[0, i].Value.ToString() + "'";

                            // Remove the row from the database
                            datab.insert(command);
                            MessageBox.Show("VIN: " + selectedRow + " successfully deleted");
                            datab.insert(command2);

                            // Remove the row from the cars dgv
                            CarsDGV.Rows.RemoveAt(i);

                            // Refreshes the DGV
                            //CarsDGV_LoadAll(datab);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            
            }
        }

        private void CarsEditButton_Click(object sender, EventArgs e)
        {
            EditCarForm edit = new EditCarForm(datab, this);
            edit.ShowDialog();
        }


        private void CarsSearchButton_Click(object sender, EventArgs e)
        {
            
            string command = "SELECT * from Car where VIN LIKE '%" + CarsVINSearchBox.Text + "%'";
            if (CarsVINSearchBox.Text == "")
            {
                command = "SELECT * from Car";
            }
            try
            {
                datab.query(command);
                CarsDGV.Rows.Clear();
                while (datab.myReader.Read())
                {
                    CarsDGV.Rows.Add(datab.myReader["VIN"].ToString(), datab.myReader["make"].ToString(), datab.myReader["model"].ToString(),
                                datab.myReader["color"].ToString(), datab.myReader["cType"].ToString(), datab.myReader["branchID"].ToString());
                }
                datab.myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void CarsShowAllButton_Click(object sender, EventArgs e)
        {
            CarsDGV_LoadAll(datab);
        }

        private void CarsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellSelectToRowSelect(CarsDGV, e);
        }
        private void CarsDGV_CellDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            CellSelectToRowSelect(CarsDGV, e);
            EditCarForm edit = new EditCarForm(datab, this);
            edit.ShowDialog();
        }

        private void VINSearch_KeyPress(object sender, KeyPressEventArgs e)
        /* listen for "enter" pressed on keyboard when edit car field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                CarsSearchButton_Click(sender, e);
            }
        }

        /*+++++++++++++++++++++++++++++++++++++++++++++Cars Panel Buttons+++++++++++++++++++++++++++++++++++++++++++++++*/

        /*+++++++++++++++++++++++++++++++++++++++++++++Car Screen Methods+++++++++++++++++++++++++++++++++++++++++++++++*/
        public void CarsDGV_LoadAll(database datab)
        {
            // Query to obtain all cars in the dataset
            datab.query("select * from Car");

            // Refresh cars in the dgv
            CarsDGV.Rows.Clear();
            while (datab.myReader.Read())
            {
                CarsDGV.Rows.Add(datab.myReader["VIN"].ToString(), datab.myReader["make"].ToString(), datab.myReader["model"].ToString(),
                              datab.myReader["color"].ToString(), datab.myReader["cType"].ToString(), datab.myReader["branchID"].ToString());
            }
            datab.myReader.Close();
        }

        public bool isMakeValid(String input)
        {
            List<string> MakeList = new List<string>(new string[] { "ACURA", "ALFA ROMEO", "ASTON MARTIN", "AUDI",
                                                                      "BENTLEY", "BMW", "BUGATTI", "BUICK", "CADILLAC",
                                                                      "CHEVROLET", "CHRYSLER", "CITROEN", "DETROIT ELECTRIC",
                                                                      "DODGE", "FERRARI", "FIAT", "FISKER", "FORD",
                                                                      "GENERAL MOTORS", "GENESIS", "GMC", "HONDA",
                                                                      "HYUNDAI", "INFINITI", "JAGUAR", "JEEP", "KARMA",
                                                                      "KIA", "LAMBORGHINI", "LAND ROVER", "LEXUS",
                                                                      "LINCOLN", "LOTUS", "LYNK CO", "MASERATI",
                                                                      "MAZDA", "MCLAREN", "MERCEDES-BENZ","MG",
                                                                      "MINI", "MITSUBISHI", "NISSAN", "PANOZ",
                                                                      "PONTIAC", "PORSCHE", "QOROS", "RAM", "ROLLS-ROYCE",
                                                                      "SAAB", "SCION", "SHELBY", "SMART", "SRT", "SUBARU",
                                                                      "SUZUKI", "TESLA", "TOYOTA", "VOLKSWAGEN", "VOLVO"});

            return MakeList.Contains(input.ToUpper());
        }
        /*+++++++++++++++++++++++++++++++++++++++++++++Car Screen Methods+++++++++++++++++++++++++++++++++++++++++++++++*/


        /*____________________________________________________Car Screen____________________________________________________*/

        /*____________________________________________________Transaction Screen____________________________________________________*/

        private void TransactionAddButton_Click(object sender, EventArgs e)
        {
            AddTransactionForm add = new AddTransactionForm(datab, this);
            add.ShowDialog();
        }

        private void TransactionSearchBox_Click(object sender, EventArgs e)
        //20190610TAG
        //TODO need to validate input or handle errors properly
        {
            string transactionSearchValue = TransactionSearchBox.Text;

            // Query to obtain the record searched
            string command = "SELECT rID, tmp.name, carID, tmp.make, tmp.model, tmp.color, tmp.dateOut, tmp.dateIn, tmp.dateExpectedIn, " +
                                    "branchOutName, branch.branchName as branchInName, tmp.eNameOut, Employee.name as eNameIn, " +
                                    "tmp.paymentInformation, tmp.totalBalance " +
                             "FROM(SELECT rID, C.name, carID, Car.make, Car.model, Car.color, R.dateOut, R.dateIn, R.dateExpectedIn, " +
                                         "B.branchName as branchOutName, R.branchOutID, R.branchInID, R.employeeOutID, R.employeeInID, " +
                                         "E.name as eNameOut, R.paymentInformation, R.totalBalance " +
                                  "FROM RentalTransaction R, Customer C, Car, Branch B, Employee E " +
                                  "WHERE R.customerID = C.cID and R.carID = Car.VIN and R.branchOutID = B.branchID and R.employeeOutID = E.eID) as tmp " +
                              "LEFT JOIN Branch on tmp.branchInID = Branch.branchID " +
                              "LEFT JOIN Employee on tmp.employeeInID = Employee.eID " +
                              //"WHERE rID = '" + transactionSearchValue + "';";
                              "WHERE rID LIKE '%" + transactionSearchValue + "%';";
            //TODO - above 2 lines, do we want exact search results or pattern search results? 

            datab.query(command);

            // Refresh cars in the dgv
            TransactionDGV.Rows.Clear();
            while (datab.myReader.Read())
            {
                TransactionDGV.Rows.Add(datab.myReader["rID"].ToString(), datab.myReader["name"].ToString(), datab.myReader["carID"].ToString(),
                              datab.myReader["dateOut"].ToString(), datab.myReader["dateIn"].ToString(), datab.myReader["dateExpectedIn"].ToString(),
                              datab.myReader["branchOutName"].ToString(), datab.myReader["branchInName"].ToString(), datab.myReader["eNameOut"].ToString(),
                              datab.myReader["eNameIn"].ToString(), datab.myReader["paymentInformation"].ToString(), datab.myReader["totalBalance"].ToString());
            }
            datab.myReader.Close();
        }

        private void TransactionSearchAll_Click(object sender, EventArgs e)
        //20190610TAG
        {
            TransactionDGV_LoadAll(datab);
        }

        private void transactionDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        //20190610TAG
        {
            CellSelectToRowSelect(TransactionDGV, e);
        }

        private void TransactionEditButton_Click(object sender, EventArgs e)
        //20190610TAG
        {
            EditTransactionForm edit = new EditTransactionForm(datab, this);
            edit.ShowDialog();
        }

        private void TransactionDeleteButton_Click(object sender, EventArgs e)
        //20190610TAG 
        {
            // As Long as there is a row to select loop
            for (int i = 0; i < TransactionDGV.Rows.Count; i++)
            {
                // Selected row to be deleted
                DataGridViewRow deleteRow = TransactionDGV.Rows[i];

                if (deleteRow.Selected == true)
                {
                    try
                    {
                        // Grab the value of the rID in the selected row for query
                        string selectedRow = TransactionDGV[0, i].Value.ToString();
                        string command = "DELETE FROM RentalTransaction WHERE rID = '" + selectedRow + "'";

                        // Remove the row from the database
                        datab.insert(command);
                        MessageBox.Show("Rental Transaction ID: " + selectedRow + " successfully deleted");

                        // Remove the row from the cars dgv
                        TransactionDGV.Rows.RemoveAt(i);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void TransactionSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        //20190611TAG
        /* listen for "enter" pressed on keyboard when search field, and submit if pressed */
        {
            if (e.KeyChar == 13)
            {
                TransactionSearchBox_Click(sender, e);
            }
        }


        /*+++++++++++++++++++++++++++++++++++++++++++++Transaction Screen Methods+++++++++++++++++++++++++++++++++++++++++++++++*/
        public void TransactionDGV_LoadAll(database datab)
        //20190610TAG
        {
            // Query to obtain all transactions in the dataset
            string command = "SELECT rID, tmp.name, carID, tmp.make, tmp.model, tmp.color, tmp.dateOut, tmp.dateIn, tmp.dateExpectedIn, " +
                                    "branchOutName, branch.branchName as branchInName, tmp.eNameOut, Employee.name as eNameIn, " +
                                    "tmp.paymentInformation, tmp.totalBalance " +
                             "FROM(SELECT rID, C.name, carID, Car.make, Car.model, Car.color, R.dateOut, R.dateIn, R.dateExpectedIn, " +
                                         "B.branchName as branchOutName, R.branchOutID, R.branchInID, R.employeeOutID, R.employeeInID, " +
                                         "E.name as eNameOut, R.paymentInformation, R.totalBalance " +
                                  "FROM RentalTransaction R, Customer C, Car, Branch B, Employee E " +
                                  "WHERE R.customerID = C.cID and R.carID = Car.VIN and R.branchOutID = B.branchID and R.employeeOutID = E.eID) as tmp " +
                              "LEFT JOIN Branch on tmp.branchInID = Branch.branchID " +
                              "LEFT JOIN Employee on tmp.employeeInID = Employee.eID ";

            datab.query(command);
            // DataTable temp = new DataTable();
            // temp.Load(datab.myReader);
            //  CustomersDGV.DataSource = temp;
            //datab.myReader.Close();
            // Refresh cars in the dgv
            TransactionDGV.Rows.Clear();
            while (datab.myReader.Read())
            {
                TransactionDGV.Rows.Add(datab.myReader["rID"].ToString(), datab.myReader["name"].ToString(), datab.myReader["carID"].ToString(),
                              datab.myReader["dateOut"].ToString(), datab.myReader["dateIn"].ToString(), datab.myReader["dateExpectedIn"].ToString(),
                              datab.myReader["branchOutName"].ToString(), datab.myReader["branchInName"].ToString(), datab.myReader["eNameOut"].ToString(),
                              datab.myReader["eNameIn"].ToString(), datab.myReader["paymentInformation"].ToString(), datab.myReader["totalBalance"].ToString());
            }
            datab.myReader.Close();
        }

        public int GetNextID(database temp)
        //20190611TAG 
        // Looks up the max rID and returns that value +1 
        {
            int result = 0;
            try
            {
                string command = "SELECT max(rID) FROM RentalTransaction";
                datab = temp;
                datab.query(command);

                datab.myReader.Read();
                Int32.TryParse(datab.myReader[0].ToString(), out result);
                datab.myReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
            return result + 1;
        }

        /*+++++++++++++++++++++++++++++++++++++++++++++Transaction Screen Methods+++++++++++++++++++++++++++++++++++++++++++++++*/

        /*____________________________________________________Transaction Screen____________________________________________________*/

        /*____________________________________________________Reports Screen____________________________________________________*/
        private void button1_Click(object sender, EventArgs e)
        {
            RevenueByBranchForm rbb = new RevenueByBranchForm(datab, this);
            rbb.ShowDialog();
        }

        private void RentalHistoryByCustomerButton_Click(object sender, EventArgs e)
        {
            RentalHistoryByCustomerForm rhc = new RentalHistoryByCustomerForm(datab, this);
            rhc.ShowDialog();
        }

        private void RentalHistoryByVehicleButton_Click(object sender, EventArgs e)
        {
            RentalHistoryByVehicleForm rhv = new RentalHistoryByVehicleForm(datab, this);
            rhv.ShowDialog();
        }

        private void MostRentedCarByDateButton_Click(object sender, EventArgs e)
        {
            MostRentedCarByDateForm mrc = new MostRentedCarByDateForm(datab, this);
            mrc.ShowDialog();
        }
        public void ReportsDGVRBB_LoadAll(database datab, DateTime startdate, DateTime enddate)
        {
            // Query to obtain all cars in the dataset
            datab.query("SELECT branchName, SUM(totalBalance) as branchTotal FROM " +
                        "(SELECT Branch.branchName, RentalTransaction.totalBalance FROM " +
                        "RentalTransaction, Branch WHERE RentalTransaction.branchOutID = Branch.branchID AND " +
                        "RentalTransaction.dateIn > '" + startdate + "' AND RentalTransaction.dateIn < '" + enddate + "') AS T " +
                        "GROUP BY branchName");

            // Refresh cars in the dgv
            ReportsRBBDGV.Rows.Clear();
            while (datab.myReader.Read())
            {
                ReportsRBBDGV.Rows.Add(datab.myReader["branchName"].ToString(), datab.myReader["branchTotal"].ToString());
                              
            }
            datab.myReader.Close();

            ReportsRHCDGV.Visible = false;
            ReportsRHVDGV.Visible = false;
            ReportsMRCDGV.Visible = false;
            ReportsRBBDGV.Visible = true;
        }

        public void ReportsDGVRHC_LoadAll(database datab, DateTime startdate, DateTime enddate, String cusname)
        {
            // Query to obtain all cars in the dataset
            datab.query("SELECT Customer.name, RentalTransaction.rID, Car.VIN, Car.make, Car.model, RentalTransaction.dateOut, RentalTransaction.dateIn, RentalTransaction.totalBalance " +
                        "FROM Customer, RentalTransaction, Car " +
                        "WHERE Customer.cID = RentalTransaction.customerID and RentalTransaction.carID = Car.VIN and  Customer.name = '" + cusname + "' and " +
                        "RentalTransaction.dateIn > '" + startdate + "' AND RentalTransaction.dateIn < '" + enddate + "' ORDER BY RentalTransaction.dateOut ASC");

            // Refresh cars in the dgv
            ReportsRHCDGV.Rows.Clear();
            while (datab.myReader.Read())
            {
                ReportsRHCDGV.Rows.Add(datab.myReader["name"].ToString(), datab.myReader["rID"].ToString(), datab.myReader["VIN"].ToString(),
                                        datab.myReader["make"].ToString(), datab.myReader["model"].ToString(), datab.myReader["dateOut"].ToString(),
                                        datab.myReader["dateIn"].ToString(), datab.myReader["totalBalance"].ToString());

            }
            datab.myReader.Close();

            ReportsRBBDGV.Visible = false;
            ReportsRHVDGV.Visible = false;
            ReportsMRCDGV.Visible = false;
            ReportsRHCDGV.Visible = true;
            
        }

        public void ReportsDGVRHV_LoadAll(database datab, DateTime startdate, DateTime enddate, String VIN)
        {
            // Query to obtain all cars in the dataset
            datab.query("SELECT Customer.name, RentalTransaction.rID, Car.VIN, Car.make, Car.model, RentalTransaction.dateOut, RentalTransaction.dateIn, RentalTransaction.totalBalance " +
                        "FROM Customer, RentalTransaction, Car " +
                        "WHERE Customer.cID = RentalTransaction.customerID and RentalTransaction.carID = Car.VIN and  Car.VIN = '" + VIN + "' and " +
                        "RentalTransaction.dateIn > '" + startdate + "' AND RentalTransaction.dateIn < '" + enddate + "' ORDER BY RentalTransaction.dateOut ASC");

            // Refresh cars in the dgv
            ReportsRHVDGV.Rows.Clear();
            while (datab.myReader.Read())
            {
                ReportsRHVDGV.Rows.Add(datab.myReader["name"].ToString(), datab.myReader["rID"].ToString(), datab.myReader["VIN"].ToString(),
                                        datab.myReader["make"].ToString(), datab.myReader["model"].ToString(), datab.myReader["dateOut"].ToString(),
                                        datab.myReader["dateIn"].ToString(), datab.myReader["totalBalance"].ToString());

            }
            datab.myReader.Close();

            ReportsRBBDGV.Visible = false;
            ReportsRHCDGV.Visible = false;
            ReportsMRCDGV.Visible = false;
            ReportsRHVDGV.Visible = true;

        }

        public void ReportsDGVMRC_LoadAll(database datab, DateTime startdate, DateTime enddate)
        {
            // Query to obtain all cars in the dataset
            datab.query(@"select carId as VIN, rentalNum as 'Rental Number', make as Make, model as Model
                        from car c, (select carID, count(carID) as rentalNum
                        from RentalTransaction
                        where datein is not null and dateout > '" + (startdate.ToString("yyyy-MM-dd")) + @"' and dateout < '" + 
                        (enddate.ToString("yyyy-MM-dd")) + @"' group by carID ) as temp
                        where temp.carID = c.VIN
                        order by rentalNum desc");

            // Refresh cars in the dgv
            //ReportsMRCDGV.Rows.Clear();

            DataTable temp = new DataTable();

            temp.Load(datab.myReader);
            ReportsMRCDGV.DataSource = temp;

            //while (datab.myReader.Read())
            //{
            //    ReportsMRCDGV.Rows.Add(datab.myReader["VIN"].ToString(), datab.myReader["rentalNum"].ToString(), datab.myReader["make"].ToString(), datab.myReader["model"].ToString());

            //}
            datab.myReader.Close();

            ReportsRBBDGV.Visible = false;
            ReportsRHCDGV.Visible = false;
            ReportsRHVDGV.Visible = false;
            ReportsMRCDGV.Visible = true;

        }


        /*____________________________________________________Reports Screen____________________________________________________*/
    }
}
