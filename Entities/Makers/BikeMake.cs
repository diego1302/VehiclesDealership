using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities.Makers
{
    internal class BikeMake
    {
        public int Id { get; set; }
        public string BikeMakeName { get; set; }

        public BikeMake(string bikeMakeName)
        {
            BikeMakeName = bikeMakeName;

        }

    }
}
