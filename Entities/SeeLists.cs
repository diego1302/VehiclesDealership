using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesDealership.Data;
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

namespace VehiclesDealership.Entities
{
    internal class SeeLists
    {
        DBConnection ctx = new DBConnection();

        #region includes the options that person can choose in each List
        
        /// <summary>
        /// It is the entry method for this class. Includes the options of Lists that can be accessed. 
        /// </summary>
        public void ListsDatabase()
        {
            WriteLine($"Which list you would like to see?:" +
                $"\n1- Colors" +
                $"\n2- Makers" +
                $"\n3- Fuel Types" +
                $"\n4- Exit");
                
            string answer = ReadLine();
            bool validation = Validations.IsnumberValidator(answer);

            while (validation == false)
            {
                ListsDatabase();
            }

            switch(int.Parse(answer))
            {
                case 1: ListColors(ctx); break;
                case 2: ListMakers(ctx); break;
                case 3: PrintOfFuelType(ctx); break;
                case 4: break;
                
            }


            WriteLine("Would you like to repeat the program? (yes/y. Aby other to terminate) ");
            if (Validations.RepeatProgram() == true)
            {
                ListsDatabase();
            }

        }

        /// <summary>
        /// Includes the different classes that have colors
        /// Bike, Car and Truck
        /// </summary>
        /// <param name="ctx"></param>
        public void ListColors(DBConnection ctx)
        {
            WriteLine($"Which Colors would like to see?:" +
                $"\n1- Bikes" +
                $"\n2- Cars" +
                $"\n3- Trucks" +
                $"\n4- Exit");

            string answer = ReadLine();
            bool validation = Validations.IsnumberValidator(answer);

            while (validation == false)
            {
                ListsDatabase();
            }

            switch (int.Parse(answer))
            {
                case 1: BikeColorsList(ctx); break;
                case 2: CarColorsList(ctx); break;
                case 3: TruckColorsList(ctx); break;
                case 4: break;

            }
            WriteLine("Would you like to print another list? (yes/y. Aby other to terminate) ");
            if (Validations.ContinueProgram() == true)
            {
                ListsDatabase();
            }

        }

        /// <summary>
        /// Includes the options each class has for Makers
        /// </summary>
        /// <param name="ctx"></param>
        public void ListMakers(DBConnection ctx)
        {
            WriteLine($"Which Maker would like to see?:" +
                $"\n1- Bikes" +
                $"\n2- Cars" +
                $"\n3- Trucks" +
                $"\n4= Exit");

            string answer = ReadLine();
            bool validation = Validations.IsnumberValidator(answer);

            while (validation == false)
            {
                ListMakers(ctx);
            }

            switch (int.Parse(answer))
            {
                case 1: BikeMakersList(ctx); break;
                case 2: CarMakerList(ctx); break;
                case 3: TruckMakerList(ctx); break;
                case 4: break;
                
            }

            WriteLine("Would you like to print another list? (yes/y. Aby other to terminate) ");
            if (Validations.ContinueProgram() == true)
            {
                ListsDatabase();
            }

        }

        public void PrintOfFuelType(DBConnection ctx)
        {
            var list = ctx.fuelTypes.Select(p => p.FuelName).ToList();
            LooptoPrintList(list);

        }
        #endregion
        //uses the user selection to print the list. 

        /// <summary>
        /// this method pick ups the list generated in the Lists methods 
        /// loops through it and prints it in the screen.
        /// </summary>
        /// <param name="list"></param>
        public void LooptoPrintList(List<string> list)
        {
            Write("\n");
            for (int i = 0; i < list.Capacity; i++)
            {
                WriteLine($"{i + 1} - {list[i]}");

            }
            
        }

        #region Includes lists of Colors for each class of vehicle


        public void BikeColorsList(DBConnection ctx)
        {
           var list = ctx.BikeColors.Select(p => p.Name).ToList();
            LooptoPrintList(list);

        }

        public void CarColorsList(DBConnection ctx)
        {
            var list = ctx.CarColors.Select(p => p.Name).ToList();
            LooptoPrintList(list);

        }

        public void TruckColorsList(DBConnection ctx)
        {
            var list = ctx.TruckColors.Select(p => p.Name).ToList();
            LooptoPrintList(list);

        }
        #endregion

        #region Includes lists of Makers for each class of vehicle

        
        public void BikeMakersList(DBConnection ctx)
        {
            var list = ctx.BikeMakes.Select(p => p.BikeMakeName).ToList();
            LooptoPrintList(list);

        }

        public void CarMakerList(DBConnection ctx)
        {
            var list = ctx.CarMakes.Select(p => p.CarMakeName).ToList();
            LooptoPrintList(list);

        }

        public void TruckMakerList(DBConnection ctx)
        {
            var list = ctx.TruckMakes.Select(p => p.TruckMakeName).ToList();
            LooptoPrintList(list);

        }
        #endregion

        

    }
}
