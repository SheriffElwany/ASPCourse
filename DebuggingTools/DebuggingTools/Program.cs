using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingTools
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var smallests = GetSmallests(numbers, 3);
           // var smallests = GetSmallests(numbers, -1);//step4
            var smallests = GetSmallests(null, 1);//step5
            foreach (var number in smallests)
                Console.WriteLine(number);

        }

        public static List<int> GetSmallests(List<int> lstNumbers,int count)
        {
            if (lstNumbers == null)//step 5
                throw new ArgumentNullException("lstNumbers","List can't be null");
          //  if (count > lstNumbers.Count)//step3
           if (count > lstNumbers.Count|| count<=0)//step3
                throw new ArgumentOutOfRangeException("count"
                    ,"Count can't be greater than the number of elements of list or equal or less than 0");
            var smallests = new List<int>();
            while (smallests.Count < count)
            {
                var min = GetSmallest(lstNumbers);
                smallests.Add(min);
                lstNumbers.Remove(min);
            }

            return smallests;
        }

        private static int GetSmallest(List<int> lstNumbers)
        {
            var min = lstNumbers[0];
            for (int i = 0; i < lstNumbers.Count ; i++)
            {
                // if (lstNumbers[i] > min) step1 
                if (lstNumbers[i] < min)//step2
                    min = lstNumbers[i];
            }
            return min;
        }
    }
}
