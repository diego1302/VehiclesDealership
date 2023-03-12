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

        public void ListsDatabase()
        {
            WriteLine($"Which list you would like to see?:" +
                $"\n1- Colors" +
                $"\n2- Makers");
            int answer = int.Parse(ReadLine());

            if (answer == 1)
            {
                ListColors(ctx);
            } else
            {
                ListMakers(ctx);
            }


        }

        //uses the user selection to print the list. 
        public void LooptoPrintList(List<string> list)
        {
            Write("\n");
            for (int i = 0; i < list.Capacity; i++)
            {
                WriteLine($"{i + 1} - {list[i]}");

            }
        }

        #region Includes lists of Colors for Bikes
        
        public void ListColors(DBConnection ctx)
        {
            WriteLine($"Which Colors would like to see?:" +
                $"\n1- Bikes" +
                $"\n2- Cars" +
                $"\n3- Trucks");
            int answer = int.Parse(ReadLine());

            switch (answer)
            {
                case 1: BikeColorsList(ctx); break;
                case 2: CarColorsList(ctx); break;
                case 3: TruckColorsList(ctx); break;

            }
            
        }

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

        #region Includes lists of Colors for Bikes

        public void ListMakers(DBConnection ctx)
        {
            WriteLine($"Which Maker would like to see?:" +
                $"\n1- Bikes" +
                $"\n2- Cars" +
                $"\n3- Trucks");
            int answer = int.Parse(ReadLine());

            switch (answer)
            {
                case 1: BikeMakersList(ctx); break;
                case 2: CarMakerList(ctx); break;
                case 3: TruckMakerList(ctx); break;

            }

        }

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
