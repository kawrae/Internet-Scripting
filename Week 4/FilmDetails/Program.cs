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

                Console.WriteLine("Enter Actor ID: ");
                int insActorID = int.Parse(Console.ReadLine());

                Film insFilm = new Film() { Title = insTitle, Year = insYear, ActorID = insActorID };
                db.Films.Add(insFilm);
                db.SaveChanges();

                List<Film> films = db.Films.ToList();
                Console.WriteLine("\nFilms Table:");
                foreach (var film in films)
                {
                    Console.WriteLine($"Film ID: {film.FilmID}");
                    Console.WriteLine($"Title: {film.Title}");
                    Console.WriteLine($"Year: {film.Year}");
                    Console.WriteLine($"Actor ID: {film.ActorID}");
                    Console.WriteLine();
                }

                List<Actor> actors = db.Actors.ToList();
                Console.WriteLine("\nActors Table:");
                foreach (var actor in actors)
                {
                    Console.WriteLine($"Actor ID: {actor.ActorID}");
                    Console.WriteLine($"Name: {actor.Firstname} {actor.Lastname}");
                    Console.WriteLine();
                }

                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
