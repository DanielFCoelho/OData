using OData.API.Entities;
using System;
using System.Collections.Generic;

namespace OData.API.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>
            {
                GetCar(),GetCar(),GetCar(),GetCar(),GetCar()
            };
        }

        private Car GetCar()
        {
            return new Car
            {
                Id = Guid.NewGuid(),
                Model = "Uno",
                Rents = GetRents()
            };
        }

        private List<Rent> GetRents()
        {
            return new List<Rent>
            {
                GetRent(), GetRent(), GetRent()
            };
        }

        private Rent GetRent()
        {
            return new Rent
            {
                Id = Guid.NewGuid(),
                RentDate = DateTime.Now,
                RentPrice = 1.99d
            };
        }
    }
}
