﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;



        public string Make { get { return make; } set { this.make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return this.year; } set { this.year = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }


        public void Drive(double distance)
        {
            double neededFuel = distance - fuelConsumption;

            if (neededFuel < fuelConsumption)
            {
                fuelQuantity -= neededFuel;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"Fuel: {FuelQuantity}");

            return result.ToString();   
        }
    }
}

