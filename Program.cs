using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesDealership.Data;
using VehiclesDealership.Entities;
using VehiclesDealership.Entities.Makers;
using VehiclesDealership.Entities.TypeOfVehicle;
using VehiclesDealership.Entities.Colors;
using VehiclesDealership.DBcon;
using static System.Console;
using System.Net.WebSockets;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Utilities;
using Google.Protobuf.Collections;
using VehiclesDealership.CreateVehicles;

namespace VehiclesDealership
{
    internal class Program
    {
        public static void Main()
        {
            var raw = new RawData();
            //if count is 4 or less data base needs to be reset?
            raw.countBikeColors();

            WriteLine("Wecolme. What would you like to do? (Type the number):");
            var answer = InitialOption();
            bool validation = Validations.IsnumberValidator(answer);

            while(validation == false)
            {
                answer = InitialOption();
                validation = Validations.IsnumberValidator(answer);
            }

            switch (int.Parse(answer))
            {
                case 1: break;
                case 2:
                    break;
                case 3:
                    CreateCar.CreateCarProgram();
                    break;
                case 4:
                    var listsPrint = new SeeLists();
                    listsPrint.ListsDatabase();
                    break;
                case 5:
                    
                    break;                
            }

            WriteLine("Thanks for visiting :) see you soon");

        }

        public static string InitialOption()
        {
            WriteLine($"\n1 - Sell" +
                $"\n2 - Buy" +
                $"\n3 - Create a Vehicle" +
                $"\n4 - See Lists" +
                $"\n5 - Exit");

            return ReadLine();

        }
    }
}
