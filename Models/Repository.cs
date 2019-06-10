using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public static  class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Id=1,Name="Star Wars",Description="Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.",ImageUrl="1.jpg"},
                new Movie(){Id=2,Name="The Green Mile",Description="The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.",ImageUrl="2.jpg"},
                new Movie(){Id=3,Name="Back to the Future",Description="Marty McFly, a 17-year-old high school student, is accidentally sent thirty years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.",ImageUrl="3.jpg"},
                new Movie(){Id=4,Name="Braveheart",Description="When his secret bride is executed for assaulting an English soldier who tried to rape her, William Wallace begins a revolt against King Edward I of England.",ImageUrl="4.jpg"},
                new Movie(){Id=5,Name="Inception",Description="A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",ImageUrl="5.jpg"}
            };
        }

        public static List<Movie> Movies{
            get{
                return _movies;
            }           
        }

        public static void AddMovie(Movie entity){
            _movies.Add(entity);
        }

        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i=>i.Id == id);
        }






    }
}