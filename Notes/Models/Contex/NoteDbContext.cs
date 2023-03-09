using Microsoft.EntityFrameworkCore;
using Notes.Models.Configure;

namespace Notes.Models.Contex
{
    //Класс в классе это сильное заявление, но работать не будет :)
    public class NoteDbContext : DbContext
    {
        private readonly string _connectionString;

        public NoteDbContext(ServiceConfigure serviceConfigure)
        {
            _connectionString = serviceConfigure.ConnectionStrings;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        public DbSet<NoteDb> NoteDbSet { get; set; }

    }
}
