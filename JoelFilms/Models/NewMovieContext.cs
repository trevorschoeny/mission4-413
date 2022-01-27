using System;
using Microsoft.EntityFrameworkCore;

namespace JoelFilms.Models
{
    public class NewMovieContext : DbContext
    {
        // Constructor
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options)
        {
            // Leave Blank For Now
        }

        public DbSet<NewMovieModel> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<NewMovieModel>().HasData(
                new NewMovieModel
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "The Avengers",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13"
                },
                new NewMovieModel
                {
                    MovieID = 2,
                    Category = "Science Fiction",
                    Title = "Interstellar",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                },
                new NewMovieModel
                {
                    MovieID = 3,
                    Category = "Drama",
                    Title = "Just Mercy",
                    Year = 2019,
                    Director = "Destin Daniel Cretton",
                    Rating = "PG-13"
                }
            );
        }
    }
}
