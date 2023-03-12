using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities
{
    internal class FuelType
    {
        public int ID { get; set; }

        public string FuelName { get; set; }

        public FuelType(string fuelName)
        {
            FuelName = fuelName;
        }
    }
}
