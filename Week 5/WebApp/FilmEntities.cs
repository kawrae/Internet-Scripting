using System;

namespace FilmDetails
{
    public class Film
    {
        public int FilmID { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public int ActorID { get; set; }
    }

    public class Actor
    {
        public int ActorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}