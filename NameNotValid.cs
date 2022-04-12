using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    [Serializable]
    public class NameNotValid :Exception
    {
        public NameNotValid()
        {

        }
        public NameNotValid(String msg)
        {
            Console.WriteLine(msg); 
        }

    }
}
