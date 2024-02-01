using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Interstellar",
                    ReleaseDate = DateTime.Parse("2014-11-05"),
                    Genre = "Sci-Fi",
                    Rating = "PG",
                    Price = 165M
                },
                new Movie
                {
                    Title = "The Martian",
                    ReleaseDate = DateTime.Parse("2015-10-02"),
                    Genre = "Sci-Fi",
                    Rating = "PG",
                    Price = 120M
                },
                new Movie
                {
                    Title = "Snowden",
                    ReleaseDate = DateTime.Parse("2016-08-12"),
                    Genre = "Thriller",
                    Rating = "PG-13",
                    Price = 40M
                },
                new Movie
                {
                    Title = "Madagascar",
                    ReleaseDate = DateTime.Parse("2017-03-15"),
                    Genre = "Animated",
                    Rating = "G",
                    Price = 23M
                }
            );
            context.SaveChanges();
        }
    }
}