using Microsoft.EntityFrameworkCore;

namespace Carcade.Models
{
    public class CarcadeContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public CarcadeContext(DbContextOptions<CarcadeContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
