using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class IdNotNegative :Exception
    {
        public IdNotNegative()
        {

        }
        public IdNotNegative(String msg)
        {
            Console.WriteLine(msg);
        }

    }
}
