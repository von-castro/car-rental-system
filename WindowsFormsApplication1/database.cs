using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental_Application
{
    public class database
    {
        // create the sql objects to use the database
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public database()
        {
            /* Starting the connection */
            SqlConnection myConnection = new SqlConnection(//"user id=" + username + ";" + // Username
                                       //"password=" + password + ";" + // Password
                                       "server=localhost;" + // IP for the server
                                       "Trusted_Connection=yes;" +
                                       "database=C291_Project; " + // Database to connect to
                                       "connection timeout=30"); // Timeout in seconds


            myConnection.Open(); // Open connection
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Link the command stream to the connection

        }
        //
        public void insert(string command)
        {

            myCommand.CommandText = command;
            //MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();


        }
        //
        public void query(string command)
        {

            myCommand.CommandText = command;
            //MessageBox.Show(myCommand.CommandText);
            myReader = myCommand.ExecuteReader();

        }
    }
}
