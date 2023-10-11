using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassHierarchy
{
    public class Car : Vehicle,VehicleOperations
    {
        private int numberOfDoors;
        private string fuelType;

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set { numberOfDoors = value; }
        }

        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }

        public override void Start()
        {
            Console.WriteLine("The Car is started.");
        }

        public override void Stop()
        {
            Console.WriteLine("The Car is stoped.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the Car engine.");
        }

        public double CalculateFuelEfficiency()
        {
            return 18;
        }


        public Car(string make, string model, int year, string color, int doors, string fuelsType)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            numberOfDoors = doors;
            fuelType = fuelsType;
        }
    }
}
