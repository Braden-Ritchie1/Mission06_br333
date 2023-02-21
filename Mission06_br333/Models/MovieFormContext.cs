using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_br333.Models
{
    public class MovieFormContext : DbContext
    {
        //Constructor
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<FormResponse> responses { get; set; }

        //'category' below refers to the table
        public DbSet<Category> category { get; set; }

        //seeding the database with my three favorite movies
        protected override void OnModelCreating(ModelBuilder mb)
        {
            //setting the cateogries with a CategoryID
            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                    new Category { CategoryID = 2, CategoryName = "Comedy"},
                    new Category { CategoryID = 3, CategoryName = "Drama"},
                    new Category { CategoryID = 4, CategoryName = "Family"},
                    new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                    new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                    new Category { CategoryID = 7, CategoryName = "Television" },
                    new Category { CategoryID = 8, CategoryName = "VHS" }
                );

            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    FormID = 1,
                    CategoryID = 1,
                    Title = "Dune",
                    Year = 2021,
                    Director = "Denis Villaneuve",
                    Rating = "PG-13",
                    Lent_to = "Braden",
                    Edited = false,
                    Notes = "My favorite movie."
                },

                new FormResponse
                {
                    FormID = 2,
                    CategoryID = 1,
                    Title = "Avatar: The Way of Water",
                    Year = 2022,
                    Director = "James Cameron",
                    Rating = "PG-13",
                    Lent_to = "Braden",
                    Edited = false,
                    Notes = "My favorite new movie."
                },

                new FormResponse
                {
                    FormID = 3,
                    CategoryID = 1,
                    Title = "Avatar",
                    Year = 2009,
                    Director = "James Cameron",
                    Rating = "PG-13",
                    Lent_to = "Braden",
                    Edited = false,
                    Notes = "My favorite older movie."
                }

            );
        }
    }
}
