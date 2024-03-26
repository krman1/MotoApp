
using MotoApp.DataProviders.Extensions;
using MotoApp.Entities;
using MotoApp.Repositories;
using System.Text;

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
            var cars = _carRepository.GetAll();
            var list = cars.Select(car => new
            {
                Identyfier = car.Id,
                ProductName = car.Name,
                ProductType = car.Type,
            });

            StringBuilder sb = new(2048);
            foreach (var car in list) 
            {
                sb.AppendLine($"Product ID: {car.Identyfier}");
                sb.AppendLine($"Product Name: {car.ProductName}");
                sb.AppendLine($"Product type: {car.ProductType}");

            }
            return sb.ToString();
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

        public List<Car> OrderByColorAndName()
        {
            var cars = _carRepository.GetAll();
            return cars
                .OrderBy(x => x.Color)
                .ThenBy(x => x.Name)
                .ToList();
        }

        public List<Car> OrderByColorAndNameDesc()
        {
            var cars = _carRepository.GetAll();
            return cars
                .OrderByDescending(x => x.Color)
                .ThenByDescending(x => x.Name)
                .ToList();
        }

        public List<Car> OrderByName()
        {
            var cars = _carRepository.GetAll();
            return cars.OrderBy(x => x.Name).ToList();
        }

        public List<Car> OrderByNameDescending()
        {
            var cars = _carRepository.GetAll();
            return cars.OrderByDescending(x => x.Name).ToList();
        }

        public List<Car> WhereColorIs(string color)
        {
            var cars = _carRepository.GetAll();
            return cars.ByColor("Red").ToList();
        }

        public List<Car> WhereStartsWhit(string prefix)
        {
            var cars = _carRepository.GetAll();
            return cars.Where(x => x.Name.StartsWith(prefix)).ToList(); 
        }

        public List<Car> WhereStartsWhitAndCostIsGreaterThan(string prefix, decimal cost)
        {
            var cars = _carRepository.GetAll();
            return cars.Where(x => x.Name.StartsWith(prefix) && x.StandardCost > cost).ToList();
        }
        public Car FirstByColor(string color)
        {
            var cars = _carRepository.GetAll();
            return cars.First(x => x.Color == color);
        }

        public Car? FirstOrDefaultByColor(string color)
        {
            var cars = _carRepository.GetAll();
            return cars.FirstOrDefault(x => x.Color == color);
        }

        public Car FirstOrDefaultByColorWithDefault(string color)
        {
            var cars = _carRepository.GetAll();
            return cars.
                FirstOrDefault(
                    x => x.Color == color,
                    new Car { Id = -1, Name = "NOT FOUND" });
        }
        public Car LastByColor(string color)
        {
            var cars = _carRepository.GetAll();
            return cars.Last(x => x.Color == color);
        }
        public Car SingleById(int id)
        {
            throw new NotImplementedException();
        }

        public Car? SingleOrDefaultById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
