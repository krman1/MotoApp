﻿
using MotoApp.Entities;

namespace MotoApp.DataProviders
{
    public interface ICarsProvider
    {
        //select
        List<Car> GetSpecificColumns();
        List<string> GetUniqueCarColors();
        decimal GetMinimumPriceOfAllCars();
        string AnonymusClass();

        // order by
        List<Car> OrderByName();
        List<Car> OrderByNameDescending();
        List<Car> OrderByColorAndName();
        List<Car> OrderByColorAndNameDesc();

        //where
        List<Car> WhereStartsWhit(string prefix);
        List<Car> WhereStartsWhitAndCostIsGreaterThan(string prefix, decimal cost);
        List<Car> WhereColorIs(string color);

        // first, last, single
        Car FirstByColor (string color);
        Car? FirstOrDefaultByColor (string color);
        Car FirstOrDefaultByColorWithDefault(string color);
        Car LastByColor (string color);
        Car SingleById (int id);
        Car? SingleOrDefaultById (int id);
    }
}
