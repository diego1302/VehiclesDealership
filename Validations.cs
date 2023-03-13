using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using VehiclesDealership.Data;
using VehiclesDealership.Entities;
using VehiclesDealership.Entities.Makers;
using VehiclesDealership.Entities.TypeOfVehicle;
using VehiclesDealership.Entities.Colors;
using VehiclesDealership.DBcon;
using Org.BouncyCastle.Utilities;

namespace VehiclesDealership
{
    internal class Validations
    {

        public static bool IsnumberValidator(string answer)
        {
            try
            {
                bool validator = int.Parse(answer) > 0 ? true : false;

                return validator;
            }
            catch
            {
                WriteLine("Please Choose a number");
            }

            return false;          

        }

        public static bool RepeatProgram()
        {
            try
            {
                //WriteLine("Would you like to repeat the program? (yes/y. Aby other to terminate) ");                
                switch (ReadLine().ToLower())
                {
                    case "yes": 
                    case "y":  return true; break;
                    default: return false;
                }
                
            }
            catch
            {
                WriteLine("Please chose a valid option");
                RepeatProgram();

            }

            return false;

        }

        public static bool ContinueProgram()
        {
            try
            {
                //WriteLine("Would you like to continue? (yes/y. Aby other to terminate) ");
                switch (ReadLine().ToLower())
                {
                    case "yes":
                    case "y": return true; break;
                    default: return false;
                }

            }
            catch
            {
                WriteLine("Please chose a valid option");
                RepeatProgram();

            }

            return false;

        }


    }
}
