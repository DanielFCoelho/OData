using Microsoft.EntityFrameworkCore;
using ODataExpand.API.Entities;

namespace ODataExpand.API.Context
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options): base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }        
    }
}
