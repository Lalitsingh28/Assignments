using LibraryManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.DBContext
{
    public class LibraryContext: DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Patron> Patrons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;");
        }


    }
}
