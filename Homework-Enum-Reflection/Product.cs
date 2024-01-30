using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Enum_Reflection
{
    internal class Product
    {
        public Product()
        {
            _no++;
            No = _no;
        }
        public Product(string name,double price,ProductType type):this()
        {
            Name = name;
            Price = price;
            Type = type;
        }
        static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType Type { get; set; }
        public override string ToString()
        {
            return $"No: {No} - Name: {Name} - Price: {Price} - Type: {Type}";
        }
    }
}
