using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullbelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            Console.WriteLine($"Has value? {number.HasValue}");
            Console.WriteLine($"value  {number.GetValueOrDefault()}");

            number = new Nullable<int>();
            Console.WriteLine($"Has value? {number.HasValue}");
            Console.WriteLine($"value  {number.GetValueOrDefault()}");


           var dec = new Nullable<decimal>(5.5m);
            Console.WriteLine($"Has value? {dec.HasValue}");
            Console.WriteLine($"value  {dec.GetValueOrDefault()}");
        }
    }
}
