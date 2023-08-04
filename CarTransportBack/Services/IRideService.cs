using CarTransportBack.Entity;

namespace CarTransportBack.Services
{
    public interface IRideService
    {
        public void Add(Ride ride);
        public void Remove(int id);
        public Ride GetRide(int id);
        public List<Ride> GetAllRides();
    }
}
