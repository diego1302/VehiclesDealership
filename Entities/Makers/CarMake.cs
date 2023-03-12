using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities.Makers
{
    internal class CarMake
    {
        public int Id { get; set; }
        public string CarMakeName { get; set; }

        public CarMake(string carMakeName)
        {
            CarMakeName = carMakeName;

        }

        public List<CarMake> LoadIntoList(List<CarMake> ListCarMake)
        {
            ListCarMake.Add(this);
            return ListCarMake;

        }

        public string PrintCarMakeName()
        {
            return this.CarMakeName.ToString();

        }

        


    }
}
