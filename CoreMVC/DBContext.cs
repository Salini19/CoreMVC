using CoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC
{
    public class DatabaseContext :DbContext
    {
        //public DBContext(DbContextOptions<DBContext> opts):base(opts) { }
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }

        public DbSet<Flight> Flights { get; set; }
    }
}
