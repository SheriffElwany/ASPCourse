using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------- sumrizedText
            string sentnce = "Microsoft launches events for developers, to make them aware about the features of new or existing products";
            var sumrizedText = sentnce.TOShortString(7);
            Console.WriteLine(sumrizedText);
            //---------------------


            //--------------- int
            int i = 200;

            bool result = i.IsGreaterThan(100);
            i.IsG();

            Console.WriteLine(result);

            //------------------

            //--------------------- WordsToMatch
            string text = @"Historically, the world of data and the world of objects " +
       @"have not been well integrated. Programmers work in C# or Visual Basic " +
       @"and also in SQL or XQuery. On the one side are concepts such as classes, " +
       @"objects, fields, inheritance, and .NET Framework APIs. On the other side " +
       @"are tables, columns, rows, nodes, and separate languages for dealing with " +
       @"them. Data types often require translation between the two worlds; there are " +
       @"different standard functions. Because the object world has no notion of query, a " +
       @"query can only be represented as a string without compile-time type checking or " +
       @"IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
       @"objects in memory is often tedious and error-prone.";
            string[] wordsToMatch = { "Historically", "data", "integrated" };
          var   sentences= text.WordsToMatch(wordsToMatch);
            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence);
            }

             wordsToMatch = new string[]{ "Because", "string" };
            sentences = text.WordsToMatch(wordsToMatch);
            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence);
            }

        }
    }
}
