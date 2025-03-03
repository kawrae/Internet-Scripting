using Microsoft.EntityFrameworkCore;

namespace FilmDetails
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options)
        : base(options) { }

        public DbSet<Film>? Films { get; set; }
        public DbSet<Actor>? Actors { get; set; }
    }
}
