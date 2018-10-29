using System.Linq;
using W2_RazorExample.Models;

namespace W2_RazorExample.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            if(context.Movie.Any())
            {
                return;
            }

            var movies = new Movie[]
            {
                new Movie
                {
                    Title = "Movie 1",
                    Genre = "Action",
                    ReleaseDate = new System.DateTime(2017, 2, 14),
                    Price = 10.50m
                },
                new Movie
                {
                    Title = "Movie 2",
                    Genre = "Comedy",
                    ReleaseDate = new System.DateTime(2015, 5, 14),
                    Price = 10.50m
                },
                new Movie
                {
                    Title = "Movie 3",
                    Genre = "Drama",
                    ReleaseDate = new System.DateTime(2018, 7, 1),
                    Price = 10.50m
                }
            };

            foreach(Movie m in movies)
            {
                context.Movie.Add(m);
            }

            context.SaveChanges();

        }
    }
}
