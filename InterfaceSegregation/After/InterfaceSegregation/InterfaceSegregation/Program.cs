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

    public interface IPrinter
    {
        void Print(Document d);
    }
    public interface IScan
    {
        void Scan(Document d);
    }

    public interface IMultiFunctionDevice:IPrinter,IScan
    {
        void Fax(Document d);
    }

    public class HighLevelDevice : IMultiFunctionDevice
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
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
