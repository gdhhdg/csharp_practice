using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Display
{
    class Home
    {
        //landing screen on startup
        public static void HomeScreen()
        { 
            string greeting = ">>>   Welcome. Begin your search below   <<<";
            Console.SetCursorPosition((Console.WindowWidth - greeting.Length) / 2, Console.CursorTop);
            Console.WriteLine(greeting);
            /*
             *a = all titles
             * c = currently available titles (all)
             * x = not available titles (all)
             * t = search by title
             * g = search by genre
             * y = search by year
             * s = search by movie Star
             */
            string choices = "\n\n\nChoose one, then press enter:\na for all titles.\nc for movies available for \nx for movies not available for checkout.\nt for title\ng for genre\ny for year\ns for star ";
            Console.WriteLine(choices);
            var selection = Console.ReadKey();

            try
            {
                string selectionString = selection.ToString().ToLower();
               if(selectionString == "a")
                {
                    Console.WriteLine("All Movies");
                }
                else if (selectionString == "c")
                {
                    Console.WriteLine("Currently Available titles");
                }
                else if(selectionString == "x")
                {
                    Console.WriteLine("Not Available titles");
                }
                else if (selectionString == "t")
                {
                    Console.WriteLine("Search by title");
                }
                else if (selectionString == "g")
                {
                    Console.WriteLine("Search by genre");
                }
                else if (selectionString == "y")
                {
                    Console.WriteLine("Search by year");
                }
                else if (selectionString == "s")
                {
                    Console.WriteLine("Seach by actor name");
                }
                
            }
            catch
            {

            }
            finally
            {

            }
        }

        
    }
}
