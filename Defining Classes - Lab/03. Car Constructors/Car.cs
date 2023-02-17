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
        private double fuelConsumption;
        private double fuelQuantity;


        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year) :this() //this () takes the first constructor
        {
            this.Make = make;  
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) :this(make, model,year) // this(make, model, year) takes the second constructor
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
            
        }

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

