namespace cSharp_SqlAssessment_MoviesRentals
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.DGVRental = new System.Windows.Forms.DataGridView();
            this.DGVmovies = new System.Windows.Forms.DataGridView();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblRented = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.infoPNL = new System.Windows.Forms.Panel();
            this.btnAllMovies = new System.Windows.Forms.Button();
            this.btnAllCustomer = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRMID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RDoutRented = new System.Windows.Forms.RadioButton();
            this.RBallRented = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtMoviePlot = new System.Windows.Forms.TextBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCutomer = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPopularMovies = new System.Windows.Forms.Button();
            this.popularCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmovies)).BeginInit();
            this.infoPNL.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCustomer.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVCustomer.Location = new System.Drawing.Point(138, 36);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.Size = new System.Drawing.Size(442, 139);
            this.DGVCustomer.TabIndex = 0;
            this.DGVCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            // 
            // DGVRental
            // 
            this.DGVRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRental.Location = new System.Drawing.Point(586, 36);
            this.DGVRental.Name = "DGVRental";
            this.DGVRental.Size = new System.Drawing.Size(409, 139);
            this.DGVRental.TabIndex = 1;
            this.DGVRental.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVrentals_CellClick);
            // 
            // DGVmovies
            // 
            this.DGVmovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVmovies.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVmovies.Location = new System.Drawing.Point(138, 211);
            this.DGVmovies.Name = "DGVmovies";
            this.DGVmovies.Size = new System.Drawing.Size(857, 212);
            this.DGVmovies.TabIndex = 2;
            this.DGVmovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVmovies_CellClick);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCustomer.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCustomer.Location = new System.Drawing.Point(145, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(106, 26);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer";
            // 
            // lblRented
            // 
            this.lblRented.AutoSize = true;
            this.lblRented.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRented.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRented.Location = new System.Drawing.Point(610, 9);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(149, 26);
            this.lblRented.TabIndex = 4;
            this.lblRented.Text = "Rental Details";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMovies.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMovies.Location = new System.Drawing.Point(161, 181);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(92, 30);
            this.lblMovies.TabIndex = 5;
            this.lblMovies.Text = "Movies";
            // 
            // infoPNL
            // 
            this.infoPNL.BackColor = System.Drawing.Color.PeachPuff;
            this.infoPNL.Controls.Add(this.popularCustomer);
            this.infoPNL.Controls.Add(this.btnPopularMovies);
            this.infoPNL.Controls.Add(this.btnAllMovies);
            this.infoPNL.Controls.Add(this.btnAllCustomer);
            this.infoPNL.Controls.Add(this.label16);
            this.infoPNL.Controls.Add(this.txtRMID);
            this.infoPNL.Controls.Add(this.panel3);
            this.infoPNL.Controls.Add(this.btnReturn);
            this.infoPNL.Controls.Add(this.btnIssue);
            this.infoPNL.Controls.Add(this.panel2);
            this.infoPNL.Controls.Add(this.panel1);
            this.infoPNL.Location = new System.Drawing.Point(121, 439);
            this.infoPNL.Name = "infoPNL";
            this.infoPNL.Size = new System.Drawing.Size(967, 235);
            this.infoPNL.TabIndex = 6;
            // 
            // btnAllMovies
            // 
            this.btnAllMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMovies.ForeColor = System.Drawing.Color.Crimson;
            this.btnAllMovies.Location = new System.Drawing.Point(307, 3);
            this.btnAllMovies.Name = "btnAllMovies";
            this.btnAllMovies.Size = new System.Drawing.Size(152, 33);
            this.btnAllMovies.TabIndex = 17;
            this.btnAllMovies.Text = "All Movies";
            this.btnAllMovies.UseVisualStyleBackColor = true;
            this.btnAllMovies.Click += new System.EventHandler(this.btnAllMovies_Click);
            // 
            // btnAllCustomer
            // 
            this.btnAllCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCustomer.ForeColor = System.Drawing.Color.Crimson;
            this.btnAllCustomer.Location = new System.Drawing.Point(466, 3);
            this.btnAllCustomer.Name = "btnAllCustomer";
            this.btnAllCustomer.Size = new System.Drawing.Size(152, 33);
            this.btnAllCustomer.TabIndex = 16;
            this.btnAllCustomer.Text = "All Customer";
            this.btnAllCustomer.UseVisualStyleBackColor = true;
            this.btnAllCustomer.Click += new System.EventHandler(this.btnAllCustomer_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.OrangeRed;
            this.label16.Location = new System.Drawing.Point(639, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "RMID";
            // 
            // txtRMID
            // 
            this.txtRMID.Location = new System.Drawing.Point(676, 14);
            this.txtRMID.Name = "txtRMID";
            this.txtRMID.Size = new System.Drawing.Size(57, 20);
            this.txtRMID.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.RDoutRented);
            this.panel3.Controls.Add(this.RBallRented);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(741, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 55);
            this.panel3.TabIndex = 12;
            // 
            // RDoutRented
            // 
            this.RDoutRented.AutoSize = true;
            this.RDoutRented.ForeColor = System.Drawing.Color.OrangeRed;
            this.RDoutRented.Location = new System.Drawing.Point(103, 29);
            this.RDoutRented.Name = "RDoutRented";
            this.RDoutRented.Size = new System.Drawing.Size(80, 17);
            this.RDoutRented.TabIndex = 2;
            this.RDoutRented.TabStop = true;
            this.RDoutRented.Text = "Out Rented";
            this.RDoutRented.UseVisualStyleBackColor = true;
            this.RDoutRented.CheckedChanged += new System.EventHandler(this.RDoutRented_CheckedChanged);
            // 
            // RBallRented
            // 
            this.RBallRented.AutoSize = true;
            this.RBallRented.ForeColor = System.Drawing.Color.OrangeRed;
            this.RBallRented.Location = new System.Drawing.Point(10, 29);
            this.RBallRented.Name = "RBallRented";
            this.RBallRented.Size = new System.Drawing.Size(74, 17);
            this.RBallRented.TabIndex = 1;
            this.RBallRented.TabStop = true;
            this.RBallRented.Text = "All Rented";
            this.RBallRented.UseVisualStyleBackColor = true;
            this.RBallRented.CheckedChanged += new System.EventHandler(this.RBallRented_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.OrangeRed;
            this.label20.Location = new System.Drawing.Point(2, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Rented Movies";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Blue;
            this.btnReturn.Location = new System.Drawing.Point(844, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 52);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.Green;
            this.btnIssue.Location = new System.Drawing.Point(756, 3);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(79, 52);
            this.btnIssue.TabIndex = 7;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtCopies);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtRating);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMovieID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtGenre);
            this.panel2.Controls.Add(this.txtMoviePlot);
            this.panel2.Controls.Add(this.btnDeleteMovie);
            this.panel2.Controls.Add(this.btnUpdateMovie);
            this.panel2.Controls.Add(this.btnAddMovie);
            this.panel2.Controls.Add(this.txtMovieYear);
            this.panel2.Controls.Add(this.txtMovieTitle);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(17, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 74);
            this.panel2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.OrangeRed;
            this.label15.Location = new System.Drawing.Point(801, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Rent Cost";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(798, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(57, 20);
            this.txtPrice.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.OrangeRed;
            this.label14.Location = new System.Drawing.Point(736, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(734, 49);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(57, 20);
            this.txtCopies.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(645, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Rating";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(624, 48);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(100, 20);
            this.txtRating.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(871, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(861, 48);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(40, 20);
            this.txtMovieID.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(271, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(436, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Plot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(149, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(26, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Title";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(258, 48);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // txtMoviePlot
            // 
            this.txtMoviePlot.Location = new System.Drawing.Point(389, 47);
            this.txtMoviePlot.Name = "txtMoviePlot";
            this.txtMoviePlot.Size = new System.Drawing.Size(229, 20);
            this.txtMoviePlot.TabIndex = 6;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMovie.Location = new System.Drawing.Point(487, 3);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteMovie.TabIndex = 5;
            this.btnDeleteMovie.Text = "Delete  Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMovie.Location = new System.Drawing.Point(367, 3);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(114, 23);
            this.btnUpdateMovie.TabIndex = 4;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.ForeColor = System.Drawing.Color.Black;
            this.btnAddMovie.Location = new System.Drawing.Point(247, 3);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(114, 23);
            this.btnAddMovie.TabIndex = 3;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(134, 48);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(100, 20);
            this.txtMovieYear.TabIndex = 2;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(16, 48);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(100, 20);
            this.txtMovieTitle.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(2, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Movie Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.btnUpdateCustomer);
            this.panel1.Controls.Add(this.btnAddCutomer);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 74);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(660, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(648, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 20);
            this.txtID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(271, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(436, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(149, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(258, 48);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(389, 47);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(487, 3);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteCustomer.TabIndex = 5;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(367, 3);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(114, 23);
            this.btnUpdateCustomer.TabIndex = 4;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCutomer
            // 
            this.btnAddCutomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddCutomer.Location = new System.Drawing.Point(247, 3);
            this.btnAddCutomer.Name = "btnAddCutomer";
            this.btnAddCutomer.Size = new System.Drawing.Size(114, 23);
            this.btnAddCutomer.TabIndex = 3;
            this.btnAddCutomer.Text = "Add Customer";
            this.btnAddCutomer.UseVisualStyleBackColor = true;
            this.btnAddCutomer.Click += new System.EventHandler(this.btnAddCutomer_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(134, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Details";
            // 
            // btnPopularMovies
            // 
            this.btnPopularMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopularMovies.ForeColor = System.Drawing.Color.Crimson;
            this.btnPopularMovies.Location = new System.Drawing.Point(307, 3);
            this.btnPopularMovies.Name = "btnPopularMovies";
            this.btnPopularMovies.Size = new System.Drawing.Size(152, 33);
            this.btnPopularMovies.TabIndex = 18;
            this.btnPopularMovies.Text = "Popular Movies";
            this.btnPopularMovies.UseVisualStyleBackColor = true;
            this.btnPopularMovies.Click += new System.EventHandler(this.btnPopularMovies_Click_1);
            // 
            // popularCustomer
            // 
            this.popularCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularCustomer.ForeColor = System.Drawing.Color.Crimson;
            this.popularCustomer.Location = new System.Drawing.Point(467, 2);
            this.popularCustomer.Name = "popularCustomer";
            this.popularCustomer.Size = new System.Drawing.Size(152, 33);
            this.popularCustomer.TabIndex = 19;
            this.popularCustomer.Text = "Popular Customer";
            this.popularCustomer.UseVisualStyleBackColor = true;
            this.popularCustomer.Click += new System.EventHandler(this.popularCustomer_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1165, 733);
            this.Controls.Add(this.infoPNL);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lblRented);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.DGVmovies);
            this.Controls.Add(this.DGVRental);
            this.Controls.Add(this.DGVCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmovies)).EndInit();
            this.infoPNL.ResumeLayout(false);
            this.infoPNL.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.DataGridView DGVRental;
        private System.Windows.Forms.DataGridView DGVmovies;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblRented;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Panel infoPNL;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCutomer;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RDoutRented;
        private System.Windows.Forms.RadioButton RBallRented;
        public System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCopies;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRating;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMovieID;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtMoviePlot;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.TextBox txtMovieTitle;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRMID;
        private System.Windows.Forms.Button btnAllCustomer;
        private System.Windows.Forms.Button btnAllMovies;
        private System.Windows.Forms.Button popularCustomer;
        private System.Windows.Forms.Button btnPopularMovies;
    }
}

