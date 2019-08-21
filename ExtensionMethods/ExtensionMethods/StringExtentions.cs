using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ExtensionMethods 1st
//namespace ExtensionMethods.Extantions //2nd
namespace System
{
    public static class StringExtentions
    {
        public static string TOShortString(this string str,int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count should be greater than or equal to zero");
            if (count == 0)
                return string.Empty;

            var words = str.Split(' ');
           
            if (words.Length <= count)
                return str;
            return string.Join(" ", words.Take(count)) + "...";


        }

        public static IEnumerable<string> WordsToMatch(this string text, string[] wordsToMatch)
        {
            string[] sentences = text.Split(new char[] { '.', '?', '!' });
      
            var sentenceQuery = from sentence in sentences
                                let w = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' },
                                                        StringSplitOptions.RemoveEmptyEntries)
                                where w.Distinct().Intersect(wordsToMatch).Count() == wordsToMatch.Count()
                                select sentence;
            return sentenceQuery;
        }
    }
}
