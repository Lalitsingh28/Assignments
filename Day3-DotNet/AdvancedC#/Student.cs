using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    internal class Student
    {

        public string Name { get; set; }
        public int Class { get; set; }
        public double Marks { get; set; }


        public Student() { }

        public Student(string name, int standard,double marks)
        {
            Name = name;
            Class = standard;
            Marks = marks;
        }
    }
}
