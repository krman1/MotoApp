
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
    }
}
