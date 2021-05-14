using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ODataExpand.API.Context;
using ODataExpand.API.Entities;
using ODataExpand.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataExpand.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<TestContext>(opt => opt.UseInMemoryDatabase("test"));
            services.AddOData();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var context = services.GetService<TestContext>();
            AdicionarDadosTeste(context);

            app.UseMvc(routeBuilder =>
            {
                routeBuilder.EnableDependencyInjection();
                routeBuilder.Expand().Filter().Count().Select().MaxTop(null);
            });
        }

        private static void AdicionarDadosTeste(TestContext context)
        {
            var lst = GetCars(5);
            context.AddRange(lst);
            context.SaveChanges();
        }

        private static List<Car> GetCars(int quant)
        {
            var lst = new List<Car>();

            for (int i = 1; i <= quant; i++)
            {
                lst.Add(GetCar(i));
            }

            return lst;
        }

        private static Car GetCar(long id) => new Car
        {           
            Model = $"Uno - {id}",
            Rents = GetRents(4)
        };

        private static List<Rent> GetRents(int quant)
        {
            var lst = new List<Rent>();

            for (int i = 1; i <= quant; i++)
            {
                lst.Add(GetRent());
            }

            return lst;
        }

        private static Rent GetRent() => new Rent
        {           
            RentDate = DateTime.Now,
            RentPrice = 1.99d
        };
    }
}
