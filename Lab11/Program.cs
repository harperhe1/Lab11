using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
 
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Name a movie category: Animated, Drama, Horror, or sci-fi");
            string userInput = Console.ReadLine();
            
                Movies m1 = new Movies("Halloween", "Horror");
                Movies m2 = new Movies("Sleeping Beauty", "Animated");
                Movies m3 = new Movies("Gone with the Wind", "Drama");
                Movies m4 = new Movies("E.T", "sci-fi");
                Movies m5 = new Movies("Star Wars", "sci-fi");
                Movies m6 = new Movies("Cinderalla", "Animated");
                Movies m7 = new Movies("Frozen", "Animated");
                Movies m8 = new Movies("Friday the 13th", "Horror");
                Movies m9 = new Movies("Thelma and Louise", "Drama");
                Movies m10 = new Movies("The Quiet Place", "Horror");
         

            List<Movies> movies = new List<Movies>(){m1, m2, m3, m4, m5, m6, m7, m8, m9, m10};
       

            List<Movies> matchingMovies = new List<Movies>();


            foreach (Movies film in movies)
            {
                if (film.Category == userInput)
                {
                    matchingMovies.Add(film);
                }
            }

            foreach (Movies film in matchingMovies)
            {
                Console.WriteLine(film.Title);
            }


        }
    }
}
