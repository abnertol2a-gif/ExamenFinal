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
                    Nombre = "El Señor de los Anillos",
                    Autor = "J.R.R. Tolkien",
                    ReleaseDate = DateTime.Parse("1954-07-29"),
                    Genre = "Fantasía",
                    Price = 10.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Crónica de una Muerte Anunciada",
                    Autor = "Gabriel García Márquez",
                    ReleaseDate = DateTime.Parse("1981-03-15"),
                    Genre = "Realismo Mágico",
                    Price = 5.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "El Principito",
                    Autor = "Antoine de Saint-Exupéry",
                    ReleaseDate = DateTime.Parse("1943-04-06"),
                    Genre = "Fábula",
                    Price = 4.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Fahrenheit 451",
                    Autor = "Ray Bradbury",
                    ReleaseDate = DateTime.Parse("1953-10-19"),
                    Genre = "Distopía",
                    Price = 6.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "El Hobbit",
                    Autor = "J.R.R. Tolkien",
                    ReleaseDate = DateTime.Parse("1937-09-21"),
                    Genre = "Fantasía",
                    Price = 7.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Orgullo y Prejuicio",
                    Autor = "Jane Austen",
                    ReleaseDate = DateTime.Parse("1813-01-28"),
                    Genre = "Romance",
                    Price = 4.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Drácula",
                    Autor = "Bram Stoker",
                    ReleaseDate = DateTime.Parse("1897-05-26"),
                    Genre = "Terror",
                    Price = 5.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "It",
                    Autor = "Stephen King",
                    ReleaseDate = DateTime.Parse("1986-09-15"),
                    Genre = "Terror",
                    Price = 9.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "El Código Da Vinci",
                    Autor = "Dan Brown",
                    ReleaseDate = DateTime.Parse("2003-03-18"),
                    Genre = "Suspenso",
                    Price = 7.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Los Juegos del Hambre",
                    Autor = "Suzanne Collins",
                    ReleaseDate = DateTime.Parse("2008-09-14"),
                    Genre = "Distopía",
                    Price = 8.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "En Llamas",
                    Autor = "Suzanne Collins",
                    ReleaseDate = DateTime.Parse("2009-09-01"),
                    Genre = "Distopía",
                    Price = 8.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Sinsajo",
                    Autor = "Suzanne Collins",
                    ReleaseDate = DateTime.Parse("2010-08-24"),
                    Genre = "Distopía",
                    Price = 8.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "El Alquimista",
                    Autor = "Paulo Coelho",
                    ReleaseDate = DateTime.Parse("1988-01-01"),
                    Genre = "Ficción Filosófica",
                    Price = 5.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "El Psicoanalista",
                    Autor = "John Katzenbach",
                    ReleaseDate = DateTime.Parse("2002-01-01"),
                    Genre = "Thriller",
                    Price = 7.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Dune",
                    Autor = "Frank Herbert",
                    ReleaseDate = DateTime.Parse("1965-08-01"),
                    Genre = "Ciencia Ficción",
                    Price = 9.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Neuromante",
                    Autor = "William Gibson",
                    ReleaseDate = DateTime.Parse("1984-07-01"),
                    Genre = "Ciencia Ficción",
                    Price = 8.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "La Chica del Tren",
                    Autor = "Paula Hawkins",
                    ReleaseDate = DateTime.Parse("2015-01-13"),
                    Genre = "Suspenso",
                    Price = 7.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Ready Player One",
                    Autor = "Ernest Cline",
                    ReleaseDate = DateTime.Parse("2011-08-16"),
                    Genre = "Ciencia Ficción",
                    Price = 8.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Harry Potter y la Piedra Filosofal",
                    Autor = "J.K. Rowling",
                    ReleaseDate = DateTime.Parse("1997-06-26"),
                    Genre = "Fantasía",
                    Price = 6.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Harry Potter y la Cámara Secreta",
                    Autor = "J.K. Rowling",
                    ReleaseDate = DateTime.Parse("1998-07-02"),
                    Genre = "Fantasía",
                    Price = 6.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Harry Potter y el Prisionero de Azkaban",
                    Autor = "J.K. Rowling",
                    ReleaseDate = DateTime.Parse("1999-07-08"),
                    Genre = "Fantasía",
                    Price = 7.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Harry Potter y el Cáliz de Fuego",
                    Autor = "J.K. Rowling",
                    ReleaseDate = DateTime.Parse("2000-07-08"),
                    Genre = "Fantasía",
                    Price = 7.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Harry Potter y la Orden del Fénix",
                    Autor = "J.K. Rowling",
                    ReleaseDate = DateTime.Parse("2003-06-21"),
                    Genre = "Fantasía",
                    Price = 8.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Harry Potter y el Misterio del Príncipe",
                    Autor = "J.K. Rowling",
                    ReleaseDate = DateTime.Parse("2005-07-16"),
                    Genre = "Fantasía",
                    Price = 8.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Harry Potter y las Reliquias de la Muerte",
                    Autor = "J.K. Rowling",
                    ReleaseDate = DateTime.Parse("2007-07-21"),
                    Genre = "Fantasía",
                    Price = 9.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "El Silmarillion",
                    Autor = "J.R.R. Tolkien",
                    ReleaseDate = DateTime.Parse("1977-09-15"),
                    Genre = "Fantasía",
                    Price = 8.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "El Perfume",
                    Autor = "Patrick Süskind",
                    ReleaseDate = DateTime.Parse("1985-10-01"),
                    Genre = "Ficción",
                    Price = 6.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "La Metamorfosis",
                    Autor = "Franz Kafka",
                    ReleaseDate = DateTime.Parse("1915-10-01"),
                    Genre = "Ficción",
                    Price = 4.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "Los Miserables",
                    Autor = "Victor Hugo",
                    ReleaseDate = DateTime.Parse("1862-01-01"),
                    Genre = "Drama",
                    Price = 7.99M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                },
                new Libro
                {
                    Nombre = "El Retrato de Dorian Gray",
                    Autor = "Oscar Wilde",
                    ReleaseDate = DateTime.Parse("1890-07-01"),
                    Genre = "Ficción",
                    Price = 5.49M,
                    Rating = "123",
                    Estado = EstadoLibro.Disponible
                }

            );
            context.SaveChanges();
        }
    }
}