using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationbetweenClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = new Text();
            txt.Width = 20;
            txt.Hight = 30;
            txt.Copy();
            txt.AddHyperLink("http://www.google.com");
        }
    }
}
