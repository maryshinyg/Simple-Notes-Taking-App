using Microsoft.EntityFrameworkCore;

namespace NotesApp.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 

        }

        public DbSet<Note> Notes { get; set; }
    }
}

