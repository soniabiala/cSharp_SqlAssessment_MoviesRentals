using Microsoft.VisualStudio.TestTools.UnitTesting;
using cSharp_SqlAssessment_MoviesRentals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace cSharp_SqlAssessment_MoviesRentals.Tests
{
    [TestClass()]
    public class checkProcedure
    {
        [TestMethod]
        public void _checkProcedure()
        {
            Database myDatabase = new Database();
            //create a connection and command and an adapter
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter();
            DataTable dt = new DataTable();
            connection.ConnectionString = @"Data Source = BIALA\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True;";
            //connection.ConnectionString =myDatabase.connection.ConnectionString;
            command.CommandText = "borrowMost";
            command.CommandType = CommandType.StoredProcedure;
            data.SelectCommand = command;
            //open the connection
            connection.Open();
            //fill the datatable from the SQL stored procedure
            data.Fill(dt);
            //close the connection
            connection.Close();
            Assert.IsNull(dt);
        }
    }
}