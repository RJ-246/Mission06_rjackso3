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

		protected override void OnModelCreating(ModelBuilder mb)
		{
			mb.Entity<NewMovieData>().HasData(
					new NewMovieData
					{
						MovieID = 1,
						Category = "Action",
						Title = "Akira",
						Year = 1988,
						Director = "Katsuhiro Otomo",
						Rating = "R",
						Edited = false
					},
					new NewMovieData
					{
                        MovieID = 2,
                        Category = "Action",
                        Title = "Blade Runner 2049",
                        Year = 2017,
                        Director = "Denis Villeneuve",
                        Rating = "R",
                        Edited = false
                    },
                    new NewMovieData
                    {
                        MovieID = 3,
                        Category = "Action",
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

