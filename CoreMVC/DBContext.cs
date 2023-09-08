using CoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }

        public DbSet<Flight> Flights { get; set; }
    }
}
