using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_SqlAssessment_MoviesRentals
{
    public partial class Form1 : Form
    {
        //create an instance of the database class
        Database myDatabase = new Database();
        Movies myMovies;
       // private Customers;
        public Form1()
        {
            InitializeComponent();
            loadDB();
            
         //   myMovies= new Movies(txtMovieID.Text="0" , txtMovieTitle.Text = null, txtRating.Text, txtMovieYear.Text, txtCopies.Text ="0",
         //           txtMoviePlot.Text, txtGenre.Text);

        }

        public void loadDB()
        {
            //load the customer dgv
            DisplayDGVcustomer();
            //load movies details into the dgv
            DisplayDGVmovies();
            //load rented movies data into the dgv
            DisplayDGVrentals();
        }

        //load the customer into dgv
        private void DisplayDGVcustomer()
        {
            //clear all the old data
            DGVCustomer.DataSource = null;
            try
            {
                DGVCustomer.DataSource = myDatabase.FillDGVcustomers();
                //pass the dataTable data to the DGV
                DGVCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //load the rented movies into the DGV
        private void DisplayDGVrentals()
        {
            //clear all the old data
            DGVRental.DataSource = null;
            try
            {
             //pass the datatable data to dgv
                DGVRental.DataSource = myDatabase.FillDGVrentals();
                DGVRental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustID =0;
            //these are the cell clicks for the values in the row that you click
            try
            {
                CustID = (int)DGVCustomer.Rows[e.RowIndex].Cells[0].Value;
                txtFirstName.Text = DGVCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DGVCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = DGVCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = DGVCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();

                //check if we are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                  
                    //fill the Rented Movies DGV according to customer
                    DGVRental.DataSource = myDatabase.FillRentalsDGVwithCutomerClick(CustID.ToString());
                    DGVRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    txtID.Text = CustID.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //load the movies data from the table into the dgv
        private void DisplayDGVmovies()
        {
            //clear all the old data
            DGVmovies.DataSource = null;
            try
            {
                DGVmovies.DataSource = myDatabase.fillDGVmovies();
                DGVmovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; ;
            }
            catch (Exception ex)   
            {




                MessageBox.Show(ex.Message);
            }
        }

        //these are the cell clicks for the values in the row that you click
        private void DGVmovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMovieID.Text = DGVmovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtRating.Text = DGVmovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMovieTitle.Text = DGVmovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMovieYear.Text = DGVmovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text= DGVmovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCopies.Text = DGVmovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMoviePlot.Text = DGVmovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtGenre.Text = DGVmovies.Rows[e.RowIndex].Cells[7].Value.ToString();

              //  myMovies(txtMovieID.Text, txtMovieTitle.Text, txtRating.Text, txtMovieYear.Text, txtCopies.Text,
              //      txtMoviePlot.Text, txtGenre.Text);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //add new cutomer
        private void btnAddCutomer_Click(object sender, EventArgs e)
        {
            string result = null;
            // validations for empty textbox input
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty) &&
                (txtPhone.Text != string.Empty) && (txtAddress.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.AddOrUpdateCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text,
                        txtAddress.Text, txtID.Text, "Add");
                    MessageBox.Show(txtFirstName.Text + "  " + txtLastName.Text + " Adding " + result);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                //update customer DGV to see new customer
                DisplayDGVcustomer();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtID.Text = "";
            }
            else
            {
                MessageBox.Show("Fill the empty fields in Add new customer");
            }

        }

        //update customer info
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string result = null;
            //only run if there is something in the textboxes
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty) &&
                (txtPhone.Text != string.Empty) && (txtAddress.Text != string.Empty) && (txtID.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.AddOrUpdateCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text,
                        txtAddress.Text, txtID.Text, "Update");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " Updating " + result);
                    //refresh customer DGV to see the updates
                    DisplayDGVcustomer();
                    DGVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Customer not Updated" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill the empty fields in update customer");
            }
        }

        //delete customer
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string result = null;
            //only run if there is something in the textboxes
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty) &&
                (txtPhone.Text != string.Empty) && (txtAddress.Text != string.Empty) && (txtID.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.AddOrUpdateCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text,
                        txtAddress.Text, txtID.Text, "Delete");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " Deleting " + result);
                    //refresh customer DGV to see the updates
                    DisplayDGVcustomer();
                    DGVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Customer not Delete" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill the empty fields in Delete customer");
            }

        }

        //add a new movie
        private void btnAddMovie_Click(object sender, EventArgs e)
        {  myMovies = new Movies("0" , txtMovieTitle.Text, txtRating.Text, txtMovieYear.Text, txtCopies.Text,
                  txtMoviePlot.Text, txtGenre.Text);
            string result = null;
            // validations for empty textbox input
            if (txtMovieTitle.Text != string.Empty)
            {
                try
                {
                  
                    //    result = myDatabase.addOrUpdateMovie(txtMovieID.Text, txtMovieTitle.Text, txtMovieYear.Text, txtRating.Text, txtCopies.Text, txtMoviePlot.Text, txtGenre.Text, "Add");

                    result = myDatabase.addOrUpdateMovie( myMovies, "Add");
                   
                  
                    
                    MessageBox.Show(txtMovieTitle.Text + " Adding " + result);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                //update Movies DGV to see new movie
                DisplayDGVmovies();
                DGVmovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                txtMovieTitle.Text = "";
                txtMovieYear.Text = "";
                txtMovieID.Text = "";
                txtMoviePlot.Text = "";
                txtRating.Text = "";
                txtCopies.Text = "";
                txtGenre.Text = "";
                txtPrice.Text = "";


            }
            else
            {
                MessageBox.Show("Fill the empty fields in Add new movie");
            }
        }

        //update movie with any new info
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            myMovies = new Movies(txtMovieID.Text, txtMovieTitle.Text, txtRating.Text, txtMovieYear.Text, txtCopies.Text,
                 txtMoviePlot.Text, txtGenre.Text);
            string result = null;
            // validations for empty textbox input
            if ((txtMovieTitle.Text != string.Empty) && (txtMovieID.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.addOrUpdateMovie(myMovies, "Update");
                   
                    MessageBox.Show(txtMovieTitle.Text + " Updating " + result);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                //update Movies DGV to see new movie
                DisplayDGVmovies();
                DGVmovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("Fill the title and movieID fields while updating movie");
            }
        }

        private void AddMovieDetailsToClass()
        {
            





        }
        //delete movie
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            string result = null;
            // validations for empty textbox input
            if (txtMovieID.Text != string.Empty)
            {
                try
                {
                    result = myDatabase.addOrUpdateMovie(myMovies, "Delete");
                   
                    MessageBox.Show(txtMovieTitle.Text + " Delete " + result);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                //update Movies DGV to see new movie
                DisplayDGVmovies();
                DGVmovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("Fill the movieID fields while deleting movie");
            }
        }

        private void RBallRented_CheckedChanged(object sender, EventArgs e)
        {
            //load rented movies data into the dgv
            DisplayDGVrentals();
        }
        //load the out rented movies into the DGV
        private void DisplayDGVOutrentals()
        {
            //clear all the old data
            DGVRental.DataSource = null;
            try
            {
                //pass the datatable data to dgv
                DGVRental.DataSource = myDatabase.FillDGVOutRentals();
                DGVRental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RDoutRented_CheckedChanged(object sender, EventArgs e)
        {

            this.Text ="Movies Out Rented = "+ myDatabase.CheckOutRentedMovies();
            DisplayDGVOutrentals();



        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int checkYear = int.Parse(DateTime.Now.Date.Year.ToString()) - 5;
            string rentCost = null;
            //check if movie is 5 year old or not

            try
            {
                if (int.Parse(txtMovieYear.Text) > checkYear)
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
            //check for custId and movieID fields not empty
            if ((txtID.Text!= string.Empty)&&(txtMovieID.Text!= string.Empty))
            {
                string result = null;
                try
                {
                    result = myDatabase.IssueOrReturnMovie(txtID.Text,txtMovieID.Text,"Issue");
                    MessageBox.Show(txtMovieTitle.Text + " Issue " + result +"\n"+ "Rent Cost : "+" $" +rentCost);
                    DGVRental.DataSource = myDatabase.FillRentalsDGVwithCutomerClick(txtID.Text);
                    //refresh the DGV
                    DGVRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select the Customer and Movie for renting");
            }
        }
        private void DGVrentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtRMID.Text = DGVRental.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtID.Text = DGVRental.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMovieID.Text = DGVRental.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string result = null;
            //check for RMID field not empty
            if ((txtRMID.Text!= string.Empty)&& (txtID.Text != string.Empty) && (txtMovieID.Text != string.Empty))
            {
               
                try
                {
                    result = myDatabase.IssueOrReturnMovie(txtID.Text, txtMovieID.Text, "Return");
                    MessageBox.Show("Movie return" +" "+ result + "!");
                    DGVRental.DataSource = myDatabase.FillRentalsDGVwithCutomerClick(txtID.Text);
                    //refresh the DGV
                    DGVRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                

            }
            else
            {
                MessageBox.Show("Select the Customer and Movie to return !");
            }
        }

      

        private void btnAllCustomer_Click(object sender, EventArgs e)
        {
            //load the customer dgv
            DisplayDGVcustomer();
            btnAllCustomer.Hide();
            popularCustomer.Show();
        }

      

        private void btnAllMovies_Click(object sender, EventArgs e)
        {
            DisplayDGVmovies();
            btnPopularMovies.Show();
            btnAllMovies.Hide();
        }

        private void popularCustomer_Click_1(object sender, EventArgs e)
        {
            //clear all the old data
            DGVCustomer.DataSource = null;
            try
            {
                DGVCustomer.DataSource = myDatabase.DGVPopularCustumers();
                //pass the dataTable data to the DGV
                DGVCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                popularCustomer.Hide();
                btnAllCustomer.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPopularMovies_Click_1(object sender, EventArgs e)
        {

            //clear all the old data
            DGVmovies.DataSource = null;
            try
            {
                DGVmovies.DataSource = myDatabase.DGVpopularMovies();
                //pass the dataTable data to the DGV
                DGVmovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            btnPopularMovies.Hide();
            btnAllMovies.Show();
        }
    }
}
