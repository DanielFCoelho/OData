using ODataExpand.API.Context;
using ODataExpand.API.Entities;
using System.Linq;

namespace ODataExpand.API.Services
{
    public class CarService : ICarService
    {
        private readonly TestContext _context;

        public CarService(TestContext context)
        {
            _context = context;
        }

        public IQueryable<Car> GetCars()
        {
            return _context.Cars;
        }
    }
}
