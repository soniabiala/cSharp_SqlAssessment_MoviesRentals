using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_SqlAssessment_MoviesRentals
{
  public  class Database
    {
        //create a connection and command and an adapter
        public SqlConnection connection = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        private SqlDataAdapter data = new SqlDataAdapter();
        //the constructer sets the dafaults upon loading the class
        public Database()
        {
            //change the connection string to run from your own movies database
           connection.ConnectionString = @"Data Source = BIALA\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True;";
           
            command.Connection = connection;
        }


        //fill the cutomer DGV
        public DataTable FillDGVcustomers()
        {
            //create a database as we only have one table , the Customer
            DataTable dTable = new DataTable();
            using (data = new SqlDataAdapter("SELECT * FROM Customer", connection))
            {
                //connect in to the DB and get the SQL
                connection.Open();
                //open a connection to the DB
                data.Fill(dTable);
                //fill the datatable from the SQL
                connection.Close();

            }
            return dTable; //pass the database data tothe data grid view
        }

        //fill DGV with popular custumers
      public DataTable DGVPopularCustumers()
      {
          DataTable dataTable = new DataTable();
          try
          {
              command.CommandText = "borrowMost";
              command.CommandType = CommandType.StoredProcedure;
              data.SelectCommand = command;
                //open the connection
                connection.Open();
                //fill the datatable from the SQL stored procedure
                data.Fill(dataTable);
                //close the connection
                connection.Close();
          }
          catch (Exception ex)
          {

              MessageBox.Show(ex.Message);
          }
          return dataTable;
      }
        //add, update or delete cutomer
        public string AddOrUpdateCustomer(string firstName, string lastName, string phone, string address, string id, string addOrUpdate)
        {
            try
            {
                if (addOrUpdate == "Add")
                {
                   //create a command, query and connection to sql server
                   var myCommand = new SqlCommand("INSERT INTO Customer(FirstName,LastName,Address,Phone)"+ "VALUES(@Firstname,@Lastname,@address,@phone)", connection);
                    //create perameters
                    myCommand.Parameters.AddWithValue("Firstname", firstName);
                    myCommand.Parameters.AddWithValue("Lastname", lastName);
                    myCommand.Parameters.AddWithValue("address", address);
                    myCommand.Parameters.AddWithValue("phone", phone);
                    connection.Open();
                    //open the connection add in the sql
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
               else if (addOrUpdate=="Update")
               {
                   var myCommand = new SqlCommand("UPDATE CUSTOMER SET FirstName=@FirstName,LastName=@lastName,Address=@address,Phone=@phone WHERE CustID = @ID",connection);
                    //perameters to prevent sql injections
                   myCommand.Parameters.AddWithValue("FirstName",firstName);
                   myCommand.Parameters.AddWithValue("LastName", lastName);
                   myCommand.Parameters.AddWithValue("Address", address);
                   myCommand.Parameters.AddWithValue("Phone", phone);
                   myCommand.Parameters.AddWithValue("ID", id);
                    connection.Open();
                   myCommand.ExecuteNonQuery();
                    connection.Close();
               }
                else if (addOrUpdate== "Delete")
                {
                    var myCommand= new SqlCommand("DELETE FROM Customer WHERE CustID = @ID",connection);
                    //perameters
                    myCommand.Parameters.AddWithValue("ID", id);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
                return "Is Successful";
            }
            catch (Exception ex)
            {
                //close the connection second time as it jumps the first connection.close() when ExecuteNonQuery() fails
                connection.Close();
                return "has failed with" + ex;
            }
        }

        //fill the movies DGV with data
        public DataTable fillDGVmovies()
        {
            DataTable dTable = new DataTable();
            using (data = new SqlDataAdapter("SELECT * FROM Movies", connection))
            {
                 //connect into the DB and get the SQL
                 connection.Open();
                //fill the database from the SQL
                data.Fill(dTable);
                //close the connection
                connection.Close();
            }
            return dTable;
        }

        //fill the movies DGV with popular movies
      public DataTable DGVpopularMovies()
      {
            DataTable dTable = new DataTable();
            using (data = new SqlDataAdapter("SELECT * FROM CountOnMovies", connection))
            {
                //connect into the DB and get the SQL
                connection.Open();
                //fill the database from the SQL
                data.Fill(dTable);
                //close the connection
                connection.Close();
            }
            return dTable;
        }

        public string addOrUpdateMovie(Movies movie, string addOrUpdate)//    string MovieId, string title, string year, string rating, string copies, string plot, string genre, string addOrUpdate)
        {
          //  DateTime currentYear = DateTime.Now.Date.Year;
            int checkYear = int.Parse(DateTime.Now.Date.Year.ToString()) -5;
            string rentCost = null;
            //check if movie is 5 year old or not

            try
            {
                if (int.Parse(movie.Year) > checkYear)
                {
                    rentCost = Convert.ToString(5.00);
                }
                else
                {
                    rentCost = Convert.ToString(2.00);
                }
              //  return rentCost;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            try
            {
                if (addOrUpdate == "Add")
                {
                    //create a command, query and connection to sql server
                    var myCommand = new SqlCommand("INSERT INTO Movies(Rating,Title,Year,Rental_Cost, Copies,Plot,Genre)" + "VALUES(@rating,@title,@year,@RentalCost,@copies,@plot,@genre)", connection);
                    //create perameters
                    myCommand.Parameters.AddWithValue("rating", movie.Rating);
                    myCommand.Parameters.AddWithValue("title",movie.Title);
                    myCommand.Parameters.AddWithValue("year",movie.Year);
                    myCommand.Parameters.AddWithValue("RentalCost", rentCost);
                    myCommand.Parameters.AddWithValue("copies",movie.Copies);
                    myCommand.Parameters.AddWithValue("plot",movie.Plot);
                    myCommand.Parameters.AddWithValue("genre",movie.Genre);
                    connection.Open();
                    //open the connection add in the sql
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
                else if (addOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Movies SET Rating=@rating,Title=@title,Year=@year, Rental_Cost=@RentalCost,Copies=@copies,Plot=@plot,Genre=@genre WHERE MovieID = @ID", connection);
                    //perameters to prevent sql injections
                    myCommand.Parameters.AddWithValue("rating", movie.Rating);
                    myCommand.Parameters.AddWithValue("title", movie.Title);
                    myCommand.Parameters.AddWithValue("year", movie.Year);
                    myCommand.Parameters.AddWithValue("RentalCost", rentCost);
                    myCommand.Parameters.AddWithValue("copies", movie.Copies);
                    myCommand.Parameters.AddWithValue("plot", movie.Plot);
                    myCommand.Parameters.AddWithValue("genre", movie.Genre);
                    myCommand.Parameters.AddWithValue("ID", movie.ID);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
                else if (addOrUpdate == "Delete")
                {
                    var myCommand = new SqlCommand("DELETE FROM Movies WHERE MovieID = @ID", connection);
                    //perameters
                    myCommand.Parameters.AddWithValue("ID", movie.ID);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
                return "Is Successful";
            }
            catch (Exception ex)
            {
                //close the connection second time as it jumps the first connection.close() when ExecuteNonQuery() fails
                connection.Close();
                return "has failed with" + ex;
            }
        }

        //fill the rentals DGV with data
        public DataTable FillDGVrentals()
        {
            DataTable dTable = new DataTable();
            using (data = new SqlDataAdapter("SELECT * FROM RentalMovies", connection))
            {
                connection.Open();
                data.Fill(dTable);
                connection.Close();
            }
            return dTable;
        }

        //load rented movies info according to the customer
        public DataTable FillRentalsDGVwithCutomerClick(string CustID)
        {
            DataTable dTable = new DataTable();
            string command = "SELECT * FROM RentalMovies WHERE CustIDFK ='"+CustID+"'";
            using (data= new SqlDataAdapter(command,connection))
            {
                //connect to the database
                connection.Open();
                //fill the datatable from SQL
                data.Fill(dTable);
                //close the connection
                connection.Close();
            }
            return dTable;
        }
        //fill the rentals DGV with rentals movies which are out 
        public DataTable FillDGVOutRentals()
        {
            DataTable dTable = new DataTable();
            using (data = new SqlDataAdapter("SELECT * FROM OutRented", connection))
            {
                connection.Open();
                data.Fill(dTable);
                connection.Close();
            }
            return dTable;
        }

        //check how many movies are OUT for renting ???
        public string CheckOutRentedMovies()
        {
          

             string sql = "SELECT COUNT(*) FROM RentedMovies WHERE DateReturned IS NULL";
            using (SqlCommand command = new SqlCommand(sql,connection)
                )
            {
                connection.Open();
               var  answer = command.ExecuteScalar().ToString();

                connection.Close();
                return answer;
            }

        }

        public string IssueOrReturnMovie(string CustID, string MovieID, string issueOrReturn)
        {
            
            try
            {
                if (issueOrReturn == "Issue")
                {
                    //create a command, query and connection to sql server
                   DateTime issueDate = DateTime.Now;
                    var myCommand = new SqlCommand("INSERT INTO RentedMovies(MovieIDFK,CustIDFK,DateRented)" + "VALUES(@movieID,@custID,@dateIssue)", connection);
                    //create perameters
                    myCommand.Parameters.AddWithValue("movieID", MovieID);
                    myCommand.Parameters.AddWithValue("custID", CustID);
                    myCommand.Parameters.AddWithValue("dateIssue",issueDate);
                    connection.Open();
                    //open the connection add in the sql
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
                else if (issueOrReturn == "Return")
                {
                    DateTime returnDate = DateTime.Now;
                    //create a command, query and connection to sql server
                    var myCommand = new SqlCommand("UPDATE RentedMovies SET DateReturned = @dateReturn WHERE CustIdFK = @custID AND MovieIDFK = @movieID", connection);
                    //create perameters

                    myCommand.Parameters.AddWithValue("custID", CustID);
                    myCommand.Parameters.AddWithValue("movieID", MovieID);
                    myCommand.Parameters.AddWithValue("dateReturn", returnDate);
                    connection.Open();
                    //open the connection add in the sql
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
                return "Is Successful";
            }
            catch (Exception ex)
            {

                //close the connection second time as it jumps the first connection.close() when ExecuteNonQuery() fails
                connection.Close();
                return "has failed with" + ex;
            }
        }

        //connection test for the unit test to see if the connection is working
      public bool ConnectionUnitTest()
      {
         
           
          try
          {
                //create a datatable can't have it global as it holds all the data
                DataTable dt = new DataTable();
                string querry = "select * from Customer";
              using (data = new SqlDataAdapter(querry, connection))
              {
                    //connect into the DB and get the querry
                    connection.Open();
                    //fill the datatable from the querry via the dataadapter
                    data.Fill(dt);
                    //close the connection
                    connection.Close();
                }
            
              return true;
                //working
          }
          catch 
          {
             
              return false;
                //not working
          }
           
      }
    }
}
