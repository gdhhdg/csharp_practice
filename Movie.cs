using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Objects
{
     public class Movie
    {
        public string title { get; set; }
        public string genre { get; set; }
        public short year { get; set; }
        public List<string> stars { get; set; }
        public bool status { get; set; } 

        public Movie(string title, string genre, short year, List<string> stars, bool status)
        {
            this.title = title;
            this.genre = genre;
            this.year = year;
            this.stars = stars;
            this.status = status;


        }
        //adding movies



        public void movieDetails()
        {
            //concatenate list of actors and add commas and 'and' if needed.
            string actorString;
            var starList = this.stars;
            var lastIndex = starList.Count() - 1;
            if (starList.Count() >= 2)
            {

                var lastElement = starList[lastIndex];
                starList[lastIndex] = "and " + lastElement;
                    }

            if (starList.Count() >= 3)
            { 
                actorString = string.Join(", ", starList.ToArray());
            } 
            else
            {
                actorString = string.Join(" ", starList.ToArray());
            }
           
            //Make a string based on checkout status of a movie
            string checkoutStatus = this.status == true ? "available for checkout" : "not available for checkout";

            //print description
            Console.WriteLine("{0} is a {1} that was released in {2}. It stars {3}. Currently {4}", this.title, this.genre, this.year, actorString, checkoutStatus);
        }

   
    }
}
