﻿using FilmeMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FilmeMvc.Models
{
    public static class PropagarBanco
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFilmeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFilmeContext>>()))
            {
                // Look for any movies.
                if (context.Filme.Any())
                {
                    return;   // DB has been seeded
                }

                context.Filme.AddRange(
                    new Filme
                    {
                        Titulo = "When Harry Met Sally",
                        DataLancamento = DateTime.Parse("1989-2-12"),
                        Genero = "Romantic Comedy",
                        Preco = 7.99M
                    },

                    new Filme
                    {
                        Titulo = "Ghostbusters ",
                        DataLancamento = DateTime.Parse("1984-3-13"),
                        Genero = "Comedy",
                        Preco = 8.99M
                    },

                    new Filme
                    {
                        Titulo = "Ghostbusters 2",
                        DataLancamento = DateTime.Parse("1986-2-23"),
                        Genero = "Comedy",
                        Preco = 9.99M
                    },

                    new Filme
                    {
                        Titulo = "Rio Bravo",
                        DataLancamento = DateTime.Parse("1959-4-15"),
                        Genero = "Western",
                        Preco = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
