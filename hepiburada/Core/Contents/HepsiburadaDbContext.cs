using hepiburada.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace hepiburada.Core.Contents
{
    public class HepsiburadaDbContext : DbContext

    {
        public HepsiburadaDbContext(DbContextOptions<HepsiburadaDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers    { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
