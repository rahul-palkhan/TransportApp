using CarTransportBack.Entity;

namespace CarTransportBack.Services
{
    public interface IUserService
    {
        public void Add(User user);
        public User Get(int id);
    }
}
