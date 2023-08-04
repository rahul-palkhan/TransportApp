using Microsoft.EntityFrameworkCore;
namespace CarTransportBack.Entity
{
    public class TransportDBContext: DbContext
    {
        public DbSet<Car> cars { get; set; }
        public DbSet<Ride> rides { get; set; }
        public DbSet<User> users { get; set; }
        public TransportDBContext(DbContextOptions<TransportDBContext> options):base(options)
        {

        }
    }
}
