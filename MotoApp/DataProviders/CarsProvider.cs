﻿
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
            throw new NotImplementedException();
        }

        public List<Car> WhereStartsWhit(string prefix)
        {
            throw new NotImplementedException();
        }

        public List<Car> WhereStartsWhitAndCostIsGreaterThan(string prefix, decimal cost)
        {
            throw new NotImplementedException();
        }
    }
}
