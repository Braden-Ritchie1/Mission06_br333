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

        //seeding the database with my three favorite movies
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    FormID = 1,
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
                    Title = "Avatar",
                    Year = 2021,
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
