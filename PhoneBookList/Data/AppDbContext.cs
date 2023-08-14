using Microsoft.EntityFrameworkCore;
using PhoneBookList.Models;

namespace PhoneBookList.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Contact> contactings { get; set; }

    }
}
