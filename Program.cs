using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Display;
using MiniProject.Objects;
namespace MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //init library
            List<Movie> MovieLibrary = new List<Movie>();
            List<string> starWarsStars = new List<string> { "Mark" };
            Movie StarWars = new Movie("Star Wars", "Sci-Fi", 1977, starWarsStars, true);
            MovieLibrary.Add(StarWars);
            List<string> godFatherStars = new List<string> { "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" };
            Movie GodFather = new Movie("God Father, The", "Drama", 1972, godFatherStars, true);
            MovieLibrary.Add(GodFather);
            List<string> shawshankRedemptionStars = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" };
            Movie ShawShankRedemption = new Movie("Shawshank Redemption, The", "Drama", 1994, shawshankRedemptionStars, true);
            MovieLibrary.Add(ShawShankRedemption);
            List<string> schindlersListStars = new List<string> { "Liam Neeson", "Ralph Fiennes", "Ben Kingsley", "Caroline Goodall" };
            Movie SchindlersList = new Objects.Movie("Shindler\'s List", "Drama", 1993, schindlersListStars, false);
            MovieLibrary.Add(SchindlersList);
            List<string> drStrangeLoveStars = new List<string> { "Peter Seller", "George Scott", "Sterling Hayden" };
            Movie DoctorStrangeLove = new Movie("Doctor Strangelove", "Comedy", 1964, drStrangeLoveStars, true);
            MovieLibrary.Add(DoctorStrangeLove);

            Home.HomeScreen();
            //foreach (Movie movie in MovieLibrary.OrderBy(t => t.title) )
            //{
            //    movie.movieDetails();
            //    Console.WriteLine("Title is " + movie.ToString());
            //}
        }
    }
}
