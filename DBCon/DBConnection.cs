using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data;
using MySql.EntityFrameworkCore;
using VehiclesDealership.Entities;
using VehiclesDealership.Entities.Colors;
using VehiclesDealership.Entities.Makers;

namespace VehiclesDealership.DBcon
{
    internal class DBConnection : DbContext
    {
        //public DbSet<Person> Persons { get; set; }

        #region Colors entities set up
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<BikeColor> BikeColors { get; set; }
        public DbSet<TruckColor> TruckColors { get; set; }

        #endregion
        public DbSet<FuelType> fuelTypes { get; set; }

        #region Car, Bike and Truck set up
        public DbSet<BikeMake> BikeMakes { get; set; }

        public DbSet<CarMake> CarMakes { get; set; }

        public DbSet<TruckMake> TruckMakes { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = $"User ID=root;Password=1032381294;Host=localhost;Port=3306;Database=Dealership;Protocol=TCP;Compress=false;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;";
            optionsBuilder.UseMySQL(cs);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            
        }

    }
}
