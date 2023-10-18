using LibraryManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.DBContext
{
    public class LibraryContext: DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Author> Authors { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
        {
        }


    }
}
