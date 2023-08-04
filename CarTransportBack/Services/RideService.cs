using CarTransportBack.Entity;

namespace CarTransportBack.Services
{
    public class RideService : IRideService
    {
        private readonly TransportDBContext _dbContext;

        public RideService(TransportDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Ride ride)
        {
            try
            {
                _dbContext.rides.Add(ride);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Ride> GetAllRides()
        {
            try
            {
                List<Ride> rides= _dbContext.rides.ToList();
                return rides;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Ride GetRide(int id)
        {
            try
            {
                return _dbContext.rides.SingleOrDefault(x => x.TripId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Remove(int id)
        {
            try
            {
                _dbContext.rides.Remove(GetRide(id));
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
