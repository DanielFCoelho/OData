using ODataExpand.API.Entities;
using System.Linq;

namespace ODataExpand.API.Services
{
    public interface ICarService
    {
        IQueryable<Car> GetCars();
    }
}
