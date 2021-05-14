using System;
using System.Collections.Generic;

namespace OData.API.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public List<Rent> Rents { get; set; }
    }
}
