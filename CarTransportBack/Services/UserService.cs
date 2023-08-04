using CarTransportBack.Entity;

namespace CarTransportBack.Services
{
    public class UserService : IUserService
    {
        private readonly TransportDBContext _dbContext;

        public UserService(TransportDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(User user)
        {
            try
            {
                _dbContext.users.Add(user);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Get(int id)
        {
            try
            {
                User? user = _dbContext.users.Find(id);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
