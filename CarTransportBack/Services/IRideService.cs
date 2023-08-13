using CarTransportBack.DTO;
using CarTransportBack.Entity;

namespace CarTransportBack.Services
{
    public interface IRideService
    {
        public void Add(Ride ride);
        public List<UpcomingsRides> GetRideByUserId(int id);
        public List<Ride> GetAllRides();
    }
}
