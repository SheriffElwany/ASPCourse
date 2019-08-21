using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Document
    {

    }
    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            Console.WriteLine("FAX");
        }

        public void Print(Document d)
        {
            Console.WriteLine("Print");
        }

        public void Scan(Document d)
        {
            Console.WriteLine("Scan");
        }
    }

    public class ClassicPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            Console.WriteLine(nameof(Print));
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
