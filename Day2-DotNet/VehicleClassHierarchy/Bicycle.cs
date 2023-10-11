using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassHierarchy
{
    public class Bicycle : Vehicle, VehicleOperations
    {
        private int numberOfGears;
        private string frameMaterial;

        public int numberOfDoors
        {
            get { return numberOfGears; }
            set { numberOfGears = value; }
        }

        public string frameMaterial
        {
            get { return frameMaterial; }
            set { frameMaterial = value; }
        }

        public override void Start()
        {
            Console.WriteLine("The Bicycle is started.");
        }

        public override void Stop()
        {
            Console.WriteLine("The Bicycle is stoped.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the Bicycle engine.");
        }

        public double CalculateFuelEfficiency()
        {
            return 100;
        }

        public Bicycle(string make, string model, int year, string color, int gears, string materialType)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            numberOfGears = gears;
            frameMaterial = materialType;
        }
    }
}
