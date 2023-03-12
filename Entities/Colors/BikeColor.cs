using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities.Colors
{
    internal class BikeColor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BikeColor(string name)
        {
            Name = name;
        }
    }
}
