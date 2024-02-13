
using MotoApp.Entities;

namespace MotoApp.DataProviders
{
    public interface ICarsProvider
    {
        List<Car> FilterCars(decimal miniPrice);
        List<string> GetUniqueCarColors();
        decimal GetMinimumPriceOfAllCars();
    }
}
