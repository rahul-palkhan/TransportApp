using CarTransportBack.Entity;

namespace CarTransportBack.Services
{
    public interface ICarService
    {
        public void Add(Car car);
        public Car GetCar(int id);
        public List<Car> GetCars();

    }
}
