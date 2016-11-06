using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_SqlAssessment_MoviesRentals
{
   public class Movies
    {

        public int ID { get; set; }

        public string Title { get; set; }

        public string Rating { get; set; }

        public string Year { get; set; }
        public int Copies { get; set; }

        public string Plot { get; set; }
        public string Genre { get; set; }


        public Movies(string iD, string title, string rating, string year, string copies, string plot, string genre)
        {
            ID =  Convert.ToInt32(iD);
            Title = title;
            Rating = rating;
            Year = year;
            Copies = Convert.ToInt32(copies);
            Plot = plot;
            Genre = genre;


        }



       

    }
}
