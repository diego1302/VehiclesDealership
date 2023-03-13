using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesDealership.Entities
{
    abstract class Vehicle
    {
        /// <summary>
        /// These properties can be public, they do not need to 
        /// </summary>
        public int Id { get; set; }
        private int ModelYear { get; set; }
        private double Price { get; set; }
        private int EngineCapacity { get; set; }
        private int NumberOfSeats { get; set; }

        private string TypeOfFuel { get; set; }

        private List<FuelType> FuelTypes { get; set; } = new();

        public Vehicle(int modelYear , double price , int engineCapacity , int numberOfSeats , string typeOfFuel)
        {
            ModelYear = modelYear;
            Price = price;
            EngineCapacity = engineCapacity;
            NumberOfSeats = numberOfSeats;
            TypeOfFuel = typeOfFuel;
            
        }

        
        #region includes the methods that will be required to be able to access the information stored in the different properties
        public int GetID()
        {
            return Id;
        }
        public int GetModelYear()
        {
            return ModelYear;
        }
        public double GetPrice()
        {
            return Price;
        }
        public int GetEngineCapacity()
        {
            return EngineCapacity;
        }
        public int GetNumberofSeats()
        {
            return NumberOfSeats;
        }

        public string GetTypeOfFuel()
        {
            return TypeOfFuel;
        }

        #endregion
    }
}
