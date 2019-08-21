using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Program
    {
        public static int Area(Rectangle r) => r.Width * r.Hight;
        static void Main(string[] args)
        {
            var rc = new Rectangle(2,3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            var sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");

            Rectangle sqc = new Square();
            sqc.Width = 4;
            Console.WriteLine($"sqc  {sqc} has area {Area(sqc)}");
        }
    }
}
