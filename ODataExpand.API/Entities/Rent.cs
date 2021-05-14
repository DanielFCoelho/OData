using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ODataExpand.API.Entities
{
    public class Rent
    {
        [Key]
        public long Id { get; set; }
        public Car Car { get; set; }
        public DateTime RentDate { get; set; }
        public double RentPrice { get; set; }
    }
}
