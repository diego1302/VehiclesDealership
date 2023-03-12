using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesDealership.Entities.Colors;
using VehiclesDealership.Entities.Makers;

namespace VehiclesDealership.Entities.TypeOfVehicle
{
    internal class Car : Vehicle
    {
        public int Id { get; set; }

        public int Doors { get; set; }

        public string CarMake { get; set; }

        public string CarColor { get; set; }


        public List<CarMake> CarMakes { get; set; } = new();
        public List<CarColor> CarColors { get; set; } = new();

        public Car(int doors , string carMake , string carColor , int modelYear, double price, int engineCapacity, int numberOfSeats) : base(modelYear, price, engineCapacity, numberOfSeats)
        {
            CarMake = carMake;
            CarColor = carColor;
            Doors = doors;

        }


    }
}
