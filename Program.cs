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

namespace VehiclesDealership
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var raw = new RawData();
            //if count is 4 or less data base needs to be reset?
            raw.countBikeColors();

            WriteLine($"Wecolme. What would you like to do?:" +
                $"\n1 - Sell" +
                $"\n2 - Buy" +
                $"\n3 - Create a Car" +
                $"\n4 - See Lists");
            int answer = int.Parse(ReadLine());
        
            switch (answer)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4:
                    var listsPrint = new SeeLists();
                    listsPrint.ListsDatabase();
                        break;
                default: WriteLine("Chose one of the options."); break;
            }



            

            WriteLine();

            

            var car = new Car(2, "Chevrolet", "Red", 2025, 15200.20, 2500 , 3);

            WriteLine();


        }
    }
}
