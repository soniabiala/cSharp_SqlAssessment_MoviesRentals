using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using cSharp_SqlAssessment_MoviesRentals;
using System.Collections.ObjectModel;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public bool CheckConnection()
        {
            Database myDatabase = new Database();
            ;
            //create a connection and command and an adapter
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter();
             DataTable dt = new DataTable();
            connection.ConnectionString = myDatabase.connection.ConnectionString;
            //create a datatable can't have it global as it holds all the data
            try
            {
                string SQL = "select * from Customer";
                using (data = new SqlDataAdapter(SQL, connection));
                //'connect in to the DB and get the SQL
                connection.Open();
                //open a connection to the DB
                data.Fill(dt);
                //fill the datatable from the SQL via the DataAdapter
                connection.Close();
                return true;
                //Working!
            }
            catch
            {
                connection.Close();
                return false;
                //Not Working"
            }

        }
    }
    
}
