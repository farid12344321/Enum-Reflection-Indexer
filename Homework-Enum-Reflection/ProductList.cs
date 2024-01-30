using Homework_Enum_Reflection.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Enum_Reflection
{
    internal class ProductList
    {
        public ProductList()
        {
            
        }
        public ProductList(Product[] products)
        {
            _products = products;
        }
        private Product[] _products;
        public Product this[byte i]
        {
            get => _products[i];
            set
            {
                if (!HasProduct(value.No))
                    throw new DublicateProductExceptin("Eyni nomreli no olmaz !");
            }
        }
        public bool HasProduct(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no) return true;
            }
            return false;
        }




    }
}
