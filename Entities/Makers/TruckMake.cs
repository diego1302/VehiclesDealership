using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities.Makers
{
   
    internal class TruckMake
    {
        public int Id { get; set; }
        public string TruckMakeName { get; set; }

        public TruckMake(string truckMakeName)
        {
            TruckMakeName = truckMakeName;

        }

    }

}
