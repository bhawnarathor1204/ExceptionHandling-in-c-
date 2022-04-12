using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    [Serializable]
    public class EmpAgeNotValid :Exception
    {
        public EmpAgeNotValid()
        {

        }
        public EmpAgeNotValid(String msg) : base(msg)
        {
            Console.WriteLine(msg); 
        }
    }
}
