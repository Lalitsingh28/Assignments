using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    internal class Product
    {

        public string Name { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, string company,double price) 
        {
            Name = name;
            Company = company;
            Price = price;
        
        }
    }
}
