using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime.CompilerServices;
using VehiclesDealership.Entities.Colors;
using VehiclesDealership.Entities;
using VehiclesDealership.Entities.Makers;
using VehiclesDealership.DBcon;

namespace VehiclesDealership.Data
{
    public class RawData
    {
        DBConnection ctx = new DBConnection();

        public void LoadRawData()
        {
            var data = new RawData();
            data.CreateColors(ctx);
            data.CreateFuelTypes(ctx);
            data.CreateBikeMake(ctx);
            data.CreateTruckMake(ctx);
            data.CreateCarMake(ctx);

        }

        #region Creates all colors for the different types of vehicles
        internal void CreateColors(DBConnection ctx)
        {
            //Create Car Color Data
            var carcolor1 = new CarColor("Red");
            var carcolor2 = new CarColor("Blue");
            var carcolor3 = new CarColor("White");
            var carcolor4 = new CarColor("Black");

            //Create Bike Color Data
            var bikecolor1 = new BikeColor("Yellow");
            var bikecolor2 = new BikeColor("Orange");
            var bikecolor3 = new BikeColor("Blue");
            var bikecolor4 = new BikeColor("Green");

            //Create Truck Color Data
            var truckColor1 = new TruckColor("Purple");
            var truckColor2 = new TruckColor("Gray");
            var truckColor3 = new TruckColor("Pink");
            var truckColor4 = new TruckColor("Brown");

            ctx.Add(carcolor1);
            ctx.Add(carcolor2);
            ctx.Add(carcolor3);
            ctx.Add(carcolor4);
            ctx.Add(bikecolor1);
            ctx.Add(bikecolor2);
            ctx.Add(bikecolor3);
            ctx.Add(bikecolor4);
            ctx.Add(truckColor1);
            ctx.Add(truckColor2);
            ctx.Add(truckColor3);
            ctx.Add(truckColor4);

            ctx.SaveChanges();
        }

        #endregion

        /// <summary>
        /// Creates the different types of fuel.
        /// </summary>
        internal void CreateFuelTypes(DBConnection ctx)
        {
            var fuel1 = new FuelType("Diesel");
            var fuel2 = new FuelType("Unleaded 91");
            var fuel3 = new FuelType("Unleaded 95");
            var fuel4 = new FuelType("Unleaded 98");

            ctx.Add(fuel1);
            ctx.Add(fuel2);
            ctx.Add(fuel3);
            ctx.Add(fuel4);

            ctx.SaveChanges();


        }

        #region Includes the different Makers
        internal void CreateBikeMake(DBConnection ctx)
        {
            var bikeMake1 = new BikeMake("KTM");
            var bikeMake2 = new BikeMake("Yamaha");
            var bikeMake3 = new BikeMake("Honda");
            var bikeMake4 = new BikeMake("Ducati");

            ctx.Add(bikeMake1);
            ctx.Add(bikeMake2);
            ctx.Add(bikeMake3);
            ctx.Add(bikeMake4);
            ctx.SaveChanges();
        }

        internal void CreateTruckMake(DBConnection ctx)
        {
            var truckMake1 = new TruckMake("Izusu");
            var truckMake2 = new TruckMake("Hino");
            var truckMake3 = new TruckMake("Mercedez");
            var truckMake4 = new TruckMake("Kenworth");

            ctx.Add(truckMake1);
            ctx.Add(truckMake2);
            ctx.Add(truckMake3);
            ctx.Add(truckMake4);
            ctx.SaveChanges();

        }

        internal void CreateCarMake(DBConnection ctx)
        {
            var carMake1 = new CarMake("Chevrolet");
            var carMake2 = new CarMake("Ford");
            var carMake3 = new CarMake("Ferrari");
            var carMake4 = new CarMake("Masserati");

            ctx.Add(carMake1);
            ctx.Add(carMake2);
            ctx.Add(carMake3);
            ctx.Add(carMake4);
            ctx.SaveChanges();

        }

        #endregion

        #region Review if data is the raw data. If not then need to reestart the data base. 

        public void countBikeColors()
        {
            var count = ctx.BikeColors.Count() == 4 ? true : false;

            if(count == false)
            {
                LoadRawData();
            }

            
        }

        public void Evaluation()
        {
            LoadRawData();
        }


        #endregion


    }
}
