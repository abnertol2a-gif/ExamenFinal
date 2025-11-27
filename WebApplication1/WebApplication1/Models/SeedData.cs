using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using MvcMovie.Data;
using System;
using System.Linq;
using WebApplication1.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebApplication1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebApplication1Context>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Libro
                {
                    Nombre = "When Harry Met Sally",
                    Autor = "R",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "123"
                },
                new Libro
                {
                    Nombre = "Ghostbusters ",
                    Autor = "R",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "123"
                },
                new Libro
                {
                    Nombre = "Ghostbusters 2",
                    Autor = "R",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "123"
                },
                new Libro
                {
                    Nombre = "Rio Bravo",
                    Autor = "R",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "123"
                }
            );
            context.SaveChanges();
        }
    }
}