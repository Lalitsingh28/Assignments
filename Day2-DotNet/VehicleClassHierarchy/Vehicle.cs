using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassHierarchy
{
    public class Vehicle
    {
        private string Make;
        private string Model;
        private int Year;
        private string Color;

        public string Model
        {
            get { return Model; }
            set { Model = value; }
        }

        public string Make
        {
            get { return Make; }
            set { Make = value; }
        }

        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }

        public string Color
        {
            get { return Color; }
            set { Color = value; }
        }



        public virtual void Start()
        {
            Console.WriteLine("The vehicle is started.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle is stoped.");
        }



    }
}
