using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using MvcMovie.Data;
using System;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models;

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
                Nombre = "La Sombra del Viento",
                Autor = "Carlos Ruiz Zafón",
                ReleaseDate = DateTime.Parse("2001-06-06"),
                Genre = "Ficción",
                Price = 7.99M,
                Rating = "123",
                Estado = EstadoLibro.Disponible
            },
            new Libro
            {
                Nombre = "Cien Años de Soledad",
                Autor = "Gabriel García Márquez",
                ReleaseDate = DateTime.Parse("1967-05-30"),
                Genre = "Realismo Mágico",
                Price = 8.99M,
                Rating = "123",
                Estado = EstadoLibro.Disponible
            },
            new Libro
            {
                Nombre = "El Nombre del Viento",
                Autor = "Patrick Rothfuss",
                ReleaseDate = DateTime.Parse("2007-03-27"),
                Genre = "Fantasía",
                Price = 9.99M,
                Rating = "123",
                Estado = EstadoLibro.Disponible
            },
            new Libro
            {
                Nombre = "1984",
                Autor = "George Orwell",
                ReleaseDate = DateTime.Parse("1949-06-08"),
                Genre = "Distopía",
                Price = 3.99M,
                Rating = "123",
                Estado = EstadoLibro.Disponible
            }

            );
            context.SaveChanges();
        }
    }
}