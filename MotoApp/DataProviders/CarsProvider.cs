
using MotoApp.Entities;
using MotoApp.Repositories;

namespace MotoApp.DataProviders
{
    internal class CarsProvider : ICarsProvider
    {
        private readonly IRepository<Car> _carRepository;

        public CarsProvider(IRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }
        public string AnonymusClass()
        {
            throw new NotImplementedException();
        }

        public decimal GetMinimumPriceOfAllCars()
        {
            var cars = _carRepository.GetAll();
            return cars.Select(x => x.ListPrice).Min();
        }

        public List<Car> GetSpecificColumns()
        {
            var cars = _carRepository.GetAll();
            var list = cars.Select(car => new Car 
            { 
                Id = car.Id,
                Name = car.Name,
                Type = car.Type,
            }).ToList();
            return list;

        }

        public List<string> GetUniqueCarColors()
        {
            var cars = _carRepository.GetAll();
            var colors = cars.Select(x => x.Color).Distinct().ToList();
            return colors;
        }
    }
}
