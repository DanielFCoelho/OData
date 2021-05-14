using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataExpand.API.Entities
{
    public class Car
    {
        [Key]
        public long Id { get; set; }
        public string Model { get; set; }
        [InverseProperty("Car")]
        public List<Rent> Rents { get; set; }
    }
}
