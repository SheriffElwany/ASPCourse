using System;

namespace ConstructorsAndInheritance
{
    public class Car: Vehicle
    {
        public Car(string _number):base(_number)
        {
            Console.WriteLine(" Car class initialized");
        }
    }
}
