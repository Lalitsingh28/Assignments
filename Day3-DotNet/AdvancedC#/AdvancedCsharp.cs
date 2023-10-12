using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_ 
{ 
    public delegate int MyDeligate(int num);

    internal class AdvancedCsharp
    {
       

        public static int Cube(int num)
        {
            return num * num * num;
        }

        public static int Square(int num)
        {
            return num * num;
        }

        public static void Main(string[] args)
        {

            MyDeligate md1 = new MyDeligate(Square);
            MyDeligate md2 = new MyDeligate(Cube);

            int square = md1(12);
            int cube = md2(3);


            Console.WriteLine("Square of number is : "+square);
            Console.WriteLine("Cube of number is : "+cube);



        }

    }
}
