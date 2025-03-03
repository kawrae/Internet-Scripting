using Microsoft.EntityFrameworkCore;

namespace FilmDetails
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Films.db");
        }
    }
}
