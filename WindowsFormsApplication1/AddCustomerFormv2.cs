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
    public partial class Form2 : Form
    {
        public database localDB;
        public Form2(database datab)
        {
            InitializeComponent();
            localDB = datab;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private int Get_NewCID(database datab)
        {
            int CID;
            string CIDquerey = @"select max(CID) as CID from Customer";
            DataTable tmptbl = new DataTable();
            datab.query(CIDquerey);
            tmptbl.Load(datab.myReader);
            CID = Convert.ToInt32(tmptbl.Rows[0]["CID"]);
            CID += 1;
            return CID;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private int Check_Input()
        {
            int flag = 1;
            if (String.IsNullOrEmpty(TextFirstName.Text))
                {
                TextFirstName.BackColor = Color.FromArgb(151,159,172) ;
                flag = 0;
            }
            else { TextFirstName.BackColor = Color.White; }
            if (String.IsNullOrEmpty(TextLastName.Text))
            {
                TextLastName.BackColor = Color.FromArgb(151, 159, 172);
                flag = 0;
            }
            else { TextLastName.BackColor = Color.White; }
            if (String.IsNullOrEmpty(TextLicenseNum.Text))
            {
                TextLicenseNum.BackColor = Color.FromArgb(151, 159, 172);
                flag = 0;
            }
            else { TextLicenseNum.BackColor = Color.White; }
            if (String.IsNullOrEmpty(TextAddress1.Text))
            {
                TextAddress1.BackColor = Color.FromArgb(151, 159, 172);
                flag = 0;
            }
            else { TextAddress1.BackColor = Color.White; }
            if (String.IsNullOrEmpty(TextCity.Text))
            {
                TextCity.BackColor = Color.FromArgb(151, 159, 172);
                flag = 0;
            }
            else { TextCity.BackColor = Color.White; }
            if (String.IsNullOrEmpty(TextPostalCode.Text))
            {
                TextPostalCode.BackColor = Color.FromArgb(151, 159, 172);
                flag = 0;
            }
            else { TextPostalCode.BackColor = Color.White; }
            if (String.IsNullOrEmpty(TextPhoneNum.Text))
            {
                TextPhoneNum.BackColor = Color.FromArgb(151, 159, 172);
                flag = 0;
            }
            else { TextPhoneNum.BackColor = Color.White; }
            if (ComboProvince.SelectedIndex == -1)
            {
                ComboProvince.BackColor = Color.FromArgb(151, 159, 172);
                flag = 0;
            }
            else { ComboProvince.BackColor = Color.White; }
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check
            if (Check_Input() == 0) 
                    {
                return;
            }

            string Customer_ID = Convert.ToString(Get_NewCID(localDB));

            //Commit new customer
            string Customer_Name = (TextFirstName.Text + TextLastName.Text);
            string Customer_License = TextLicenseNum.Text;

            string Customer_address = TextAddress1.Text;
            string Customer_city = TextCity.Text;
            string Customer_Province = ComboProvince.Text;
            string Customer_PostalCode = TextPostalCode.Text;
            string Customer_PhoneNum = TextPhoneNum.Text;

            string Insert_String = @"insert into Customer values " + "('" + Customer_ID + "','" +
                Customer_License + "','" + Customer_Name + "','" + Customer_PhoneNum + "','" +
                Customer_address + "','" + Customer_city + "','" + Customer_Province + "','" + Customer_PostalCode + "')";

            localDB.insert(Insert_String);


            //string test = "SELECT cID FROM Customer WHERE cID = " + Customer_ID;

            //localDB.query(test);
            //int custID = localDB.myReader.Read().

            //string MemberStatus_Update = @"INSERT INTO MemberStatus(cID, sinceDate) VALUES
            //                         ((SELECT cID FROM Customer WHERE cID = " + Customer_ID + "), " + DateTime.Now.ToString("yyyy-MM-dd") + ")";

            //localDB.insert(MemberStatus_Update);
            this.Close();
        }
    }
}
