using System;

namespace OData.API.Entities
{
    public class Rent
    {
        public Guid Id { get; set; }
        public Car Car { get; set; }
        public DateTime RentDate { get; set; }
        public double RentPrice { get; set; }
    }
}