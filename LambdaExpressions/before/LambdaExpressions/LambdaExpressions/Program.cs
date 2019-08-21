using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression 

            Console.WriteLine(Square(5));
            //()=>
            //x=>....
            //(x,y,z)=>...
            //Func<int, int> square = Square;
            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));


            const int factor = 10;

            Func<int, int> multipler = n => n * factor;

            Console.WriteLine(multipler(20));

            var menuItems = MuneItemsRepo.GetMuneItems();

            var itemsLessThan15 = menuItems.FindAll(IsCheaperThan15Dollar);

            foreach (var item in itemsLessThan15)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine("------------------------------------");
            itemsLessThan15 = menuItems.FindAll(item=> item.Price<15.00f);
            foreach (var item in itemsLessThan15)
            {
                Console.WriteLine(item.Title);
            }
        }

        static int Square(int number)
        {
            return number * number;
        }

        static bool IsCheaperThan15Dollar(MuneItem muneItem)
        {
            return muneItem.Price < 15.00;
        }
    }
}
