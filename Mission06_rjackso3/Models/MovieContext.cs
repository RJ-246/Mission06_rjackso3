using System;
using Microsoft.EntityFrameworkCore;

namespace Mission06_rjackso3.Models
{
	public class MovieContext : DbContext
	{
		// Constructor method
		public MovieContext(DbContextOptions<MovieContext> options) : base (options)
		{

		}

		public DbSet<NewMovieData> Responses { get; set; }
		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder mb)
		{

            mb.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryID = 1,
                        CategoryName = "Action/Adventure"
                    },
                    new Category
                    {
                        CategoryID = 2,
                        CategoryName = "Comedy"
                    },
                    new Category
                    {
                        CategoryID = 3,
                        CategoryName = "Drama"
                    },
                    new Category
                    {
                        CategoryID = 4,
                        CategoryName = "Family"
                    },
                    new Category
                    {
                        CategoryID = 5,
                        CategoryName = "Horror/Suspense"
                    },
                    new Category
                    {
                        CategoryID = 6,
                        CategoryName = "Television"
                    },
                    new Category
                    {
                        CategoryID = 7,
                        CategoryName = "VHS"
                    }
                );

            mb.Entity<NewMovieData>().HasData(
					new NewMovieData
					{
						MovieID = 1,
						CategoryID = 1,
						Title = "Akira",
						Year = 1988,
						Director = "Katsuhiro Otomo",
						Rating = "R",
						Edited = false
					},
					new NewMovieData
					{
                        MovieID = 2,
                        CategoryID = 1,
                        Title = "Blade Runner 2049",
                        Year = 2017,
                        Director = "Denis Villeneuve",
                        Rating = "R",
                        Edited = false
                    },
                    new NewMovieData
                    {
                        MovieID = 3,
                        CategoryID = 1,
                        Title = "Drive",
                        Year = 2011,
                        Director = "Nicolas Winding Refn",
                        Rating = "R",
                        Edited = false
                    }
                );

		}
	}
}

