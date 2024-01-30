using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Enum_Reflection.Exceptions
{
    internal class DublicateProductExceptin:Exception
    {
        public DublicateProductExceptin(string message):base(message)
        {
            
        }
    }
}
