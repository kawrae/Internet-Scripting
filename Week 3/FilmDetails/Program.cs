using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FilmDetails;

namespace FilmDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Film Details");

            using (FilmContext db = new FilmContext())
            {
                db.Database.EnsureCreated();

                Console.WriteLine("Enter a film title: ");
                string insTitle = Console.ReadLine();

                Console.WriteLine("Enter release year: ");
                int insYear = int.Parse(Console.ReadLine());

                Film insFilm = new Film() { Title = insTitle, Year = insYear };
                db.Films.Add(insFilm);
                // db.SaveChanges();

                Console.WriteLine("Enter a film ID: ");
                int selFilmID = int.Parse(Console.ReadLine());

                Film selFilm = db.Films.SingleOrDefault(f => f.FilmID == selFilmID);
                if (selFilm != null)
                {
                    Console.WriteLine($"Selected Film: {selFilm.FilmID} - {selFilm.Title} ({selFilm.Year})");
                }
                else
                {
                    Console.WriteLine("No film found with that ID.");
                }

                List<Film> films = db.Films.ToList();

                foreach (var film in films)
                {
                    Console.WriteLine($"Film ID: {film.FilmID}");
                    Console.WriteLine($"Title: {film.Title}");
                    Console.WriteLine($"Year: {film.Year}");
                    Console.WriteLine();
                }
            }
        }
    }
}
