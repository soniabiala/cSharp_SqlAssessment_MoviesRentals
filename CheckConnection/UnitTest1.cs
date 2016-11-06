using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cSharp_SqlAssessment_MoviesRentals;
using System.Data.SqlClient;
using System.Data;

namespace CheckConnection
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        
        public void CheckConnection()
        {
          Database myDatabase = new Database();
        Assert.IsTrue(myDatabase.ConnectionUnitTest());
        }

        [TestMethod]
        public void CheckYear()
        {
            //check if the year is less than 5 year 
            int yearNow = (DateTime.Now.Date.Year);
            int movieYear = 2014;
            int old = (yearNow - movieYear);
            Assert.IsTrue(old <=5);
        }
    }
    

}
