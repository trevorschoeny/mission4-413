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
        public DbSet<CategoryModel> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    CategoryID = 1,
                    CategoryName = "Action"
                },
                new CategoryModel
                {
                    CategoryID = 2,
                    CategoryName = "Comedy"
                },
                new CategoryModel
                {
                    CategoryID = 3,
                    CategoryName = "Drama"
                },
                new CategoryModel
                {
                    CategoryID = 4,
                    CategoryName = "Fantasy"
                },
                new CategoryModel
                {
                    CategoryID = 5,
                    CategoryName = "Horror"
                },
                new CategoryModel
                {
                    CategoryID = 6,
                    CategoryName = "Mystery"
                },
                new CategoryModel
                {
                    CategoryID = 7,
                    CategoryName = "Romance"
                },
                new CategoryModel
                {
                    CategoryID = 8,
                    CategoryName = "Thriller"
                },
                new CategoryModel
                {
                    CategoryID = 9,
                    CategoryName = "Western"
                },
                new CategoryModel
                {
                    CategoryID = 10,
                    CategoryName = "Science Fiction"
                },
                new CategoryModel
                {
                    CategoryID = 11,
                    CategoryName = "Animation"
                }
                );
            mb.Entity<NewMovieModel>().HasData(
                new NewMovieModel
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "The Avengers",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13"
                },
                new NewMovieModel
                {
                    MovieID = 2,
                    CategoryID = 10,
                    Title = "Interstellar",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                },
                new NewMovieModel
                {
                    MovieID = 3,
                    CategoryID = 3,
                    Title = "Just Mercy",
                    Year = 2019,
                    Director = "Destin Daniel Cretton",
                    Rating = "PG-13"
                },
                new NewMovieModel
                {
                    MovieID = 4,
                    CategoryID = 11,
                    Title = "Toy Story",
                    Year = 1995,
                    Director = "John Lasseter",
                    Rating = "G"
                }
            );
        }
    }
}
