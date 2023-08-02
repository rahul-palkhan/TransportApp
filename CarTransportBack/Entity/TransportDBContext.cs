using Microsoft.EntityFrameworkCore;
namespace CarTransportBack.Entity
{
    public class TransportDBContext: DbContext
    {
        DbSet<Car> cars { get; set; }
        DbSet<Ride> rides { get; set; }
        DbSet<User> users { get; set; }
        public TransportDBContext(DbContextOptions<TransportDBContext> options):base(options)
        {

        }
    }
}
