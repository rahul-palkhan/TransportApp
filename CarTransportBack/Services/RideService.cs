using CarTransportBack.DTO;
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

        public List<UpcomingsRides> GetRideByUserId(int id)
        {
            try
            {
                
                List<UpcomingsRides> ride=(from r in _dbContext.rides
                                 join u in _dbContext.users on r.UserId equals u.UserId
                                 select new UpcomingsRides { DriverName=u.UserName,UserId=u.UserId,Start=r.Start,End=r.End,NoOfSeats=r.NoOfSeats,isCompleted=r.isCompleted}).ToList();
                return ride;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
