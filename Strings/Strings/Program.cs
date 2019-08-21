using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = @"As tensions rise between Iran, the United States and its allies, the BBC has been given rare access to Iran.
Iranians remain furious that President Donald Trump pulled out of the nuclear deal last year and has imposed crushing sanctions on the country";
        var SummrizedText = StringUtility.SummrizeText(text);
            Console.WriteLine(SummrizedText);
            Console.ReadLine();
        }

      
    }
}
