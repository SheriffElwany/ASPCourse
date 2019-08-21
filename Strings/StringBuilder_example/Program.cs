using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sbstr = new StringBuilder("We are the world");
            Console.WriteLine(sbstr);

            sbstr.Append("we are the people");
            Console.WriteLine(sbstr);

            sbstr.Append("Hello people");
            Console.WriteLine(sbstr);

            float currency = 3400.50f;
            sbstr.AppendFormat(" Our individual salary : {0:C}. ", currency);
            Console.WriteLine(sbstr);

            sbstr.Insert(11, "people of ");
            Console.WriteLine(sbstr);

            sbstr.Remove(11, 10);
            Console.WriteLine(sbstr);

            sbstr.Replace("world", "Indian");
            Console.WriteLine(sbstr);

            Console.ReadKey();
        }
    }
}
