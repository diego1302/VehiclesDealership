using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities
{
    internal class BikeColors
    {
        public int Id { get; set; }
        protected string Name { get; set; }

        public BikeColors(string name)
        {
            Name = name;
        }
    }
}
