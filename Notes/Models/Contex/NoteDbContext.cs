using Microsoft.EntityFrameworkCore;

namespace Notes.Models.Contex
{
    public class NoteDbContext : DbContext
    {
        public class NotesDbContext : DbContext
        {
            private readonly string _connectionString;

            public NotesDbContext(ServiceConfigure serviceConfigure)
            {
                _connectionString = serviceConfigure.ConnectionStrings["DefaultConnection"];
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
            public DbSet<NoteItem> NoteDbSet { get; set; }

        }
    }
}
