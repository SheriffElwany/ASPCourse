using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
   public class StringUtility
    {
        public static string SummrizeText(string sentence)
        {
            if (sentence.Length < Convert.ToInt32(SummrizeTextLength.MaxLenght))
                return sentence;
            var words = sentence.Split(' ');
            int totalChar = 0;
            var summryWords = new List<string>();
            foreach (var word in words)
            {
                summryWords.Add(word);
                totalChar += word.Length + 1;// for whiteSpace;
                if (totalChar > Convert.ToInt32(SummrizeTextLength.MaxLenght))
                    break;
            }

            var summry = string.Join(" ", summryWords) + ".....";
            return summry;
        }
    }
}
