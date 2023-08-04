using CarTransportBack.Entity;

namespace CarTransportBack.Services
{
    public class CarService : ICarService
    {
        private readonly TransportDBContext _dbContext;

        public CarService(TransportDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Car car)
        {
            try
            {
                _dbContext.cars.Add(car);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Car GetCar(int id)
        {
            try
            {
                return _dbContext.cars.SingleOrDefault(x => x.CarId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Car> GetCars()
        {
            try
            {
                return _dbContext.cars.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
