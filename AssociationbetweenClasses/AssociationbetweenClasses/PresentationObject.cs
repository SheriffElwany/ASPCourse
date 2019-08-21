using System;
using static System.Console;

namespace AssociationbetweenClasses
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Hight { get; set; }

        public void Copy()
        {
            WriteLine("copy object");
        }
        public void Move()
        {
           WriteLine("Move Object");
        }
    }
}
