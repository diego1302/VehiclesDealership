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


namespace VehiclesDealership.CreateVehicles
{
    internal class CreateCar
    {
        public static void CreateCarProgram()
        {
            WriteLine($"Welcomme. Are you sure you want to create a vehicle?");
            
            if (Validations.ContinueProgram() == false)
            {
                Program.Main();
                
            }else
            {
                WriteLine($"Perfect. You will need the following information to create a vehicle:" +
               $"\nNumber of doors, Car Maker, Car Color, Model Year, Price, Engine Capacity cc, Number of seats");
                var lists = new SeeLists();
                DBConnection ctx = new DBConnection();

                WriteLine("Number of doors:");
                int numberofDoors = int.Parse(ReadLine());

                WriteLine($"Car Maker: (Type one from the list)");
                lists.CarMakerList(ctx);
                var CarMaker = ReadLine();

                WriteLine($"Car Color: (Type one from the list)");
                lists.CarColorsList(ctx);
                var CarColor = ReadLine();

                WriteLine($"Model year:");
                int modelYear = int.Parse(ReadLine());

                WriteLine($"Model price:");
                double price = double.Parse(ReadLine());

                WriteLine($"Engine Capacity cc:");
                int engineCapacity = int.Parse(ReadLine());

                WriteLine($"Number of Seats:");
                int numberOfSeats = int.Parse(ReadLine());

                WriteLine($"Type of fuel:");
                var typeOfFuel= ReadLine();

                var car = new Car(numberofDoors, CarMaker, CarColor, modelYear, price, engineCapacity, numberOfSeats, typeOfFuel);
                

                WriteLine($"Would you like to repeat the program?");
                if (Validations.RepeatProgram() == true)
                {
                    CreateCar.CreateCarProgram();
                }

            }

           

        }
    }
}
