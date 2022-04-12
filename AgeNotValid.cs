using System.Runtime.Serialization;

namespace ExceptionHandling
{
    [Serializable]
    public class AgeNotValid : Exception
    {
        public AgeNotValid()
        {
            Console.WriteLine("Your age is below 18");
        }

        public AgeNotValid(String msg)
        {
           Console.WriteLine(msg);
        }

       
    }
}