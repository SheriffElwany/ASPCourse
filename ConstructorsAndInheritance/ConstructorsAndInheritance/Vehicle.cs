using System;

namespace ConstructorsAndInheritance
{
    public class Vehicle
    {
        private readonly string _regNumber;

        //public Vehicle()//step 1
        //{
        //    Console.WriteLine(" Vehicle class initialized");
        //}

        public Vehicle(string regNumber)//step 2
        {
            Console.WriteLine($"registartion number {regNumber}");
            this._regNumber = regNumber;
        }
    }
}
