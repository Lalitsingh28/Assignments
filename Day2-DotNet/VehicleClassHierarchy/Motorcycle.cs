using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassHierarchy
{
    public  class Motorcycle :Vehicle, VehicleOperations
    {
        private string engineType;

        public string engineType
        {
            get { return engineType; }
            set { engineType = value; }
        }


        public override void Start()
        {
            Console.WriteLine("The Motorcycle is started.");
        }

        public override void Stop()
        {
            Console.WriteLine("The Motorcycle is stoped.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the Motorcycle engine.");
        }

        public double CalculateFuelEfficiency()
        {
            return 45;
        }


        public Motorcycle(string make, string model, int year, string color, string engType)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            engineType = engType;
        }
    }
}
