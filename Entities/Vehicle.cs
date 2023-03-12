using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities
{
    abstract class Vehicle
    {
        private int Id { get; set; }
        private int ModelYear { get; set; }
        private double Price { get; set; }
        private int EngineCapacity { get; set; }
        private int NumberOfSeats { get; set; }

        private List<FuelType> FuelTypes { get; set; } = new();

        public Vehicle(int modelYear , double price , int engineCapacity , int numberOfSeats)
        {
            ModelYear = modelYear;
            Price = price;
            EngineCapacity = engineCapacity;
            NumberOfSeats = numberOfSeats;
            
        }

    }
}
