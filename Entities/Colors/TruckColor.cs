using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities.Colors
{
    internal class TruckColor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TruckColor(string name)
        {
            Name = name;
        }
    }
}
