
using MotoApp.Entities;

namespace MotoApp.DataProviders
{
    public interface ICarsProvider
    {
        List<Car> GetSpecificColumns();
        List<string> GetUniqueCarColors();
        decimal GetMinimumPriceOfAllCars();
        string AnonymusClass();
    }
}
