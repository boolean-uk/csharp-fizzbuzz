using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fizzbuzz.Main
{
    public class Extension
    {
        public string[] fizzbuzz(int lower, int higher)
        {
            // throw new NotImplementedException();

            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */

            int lim = 0;

            if (lower > 0 && higher > 0)
            {
                lim = higher - lower + 1;
            }

            if (lower < 0 && higher < 0)
            {
               lim = -(higher) + -(lower) + 1;
            }

            if (lower < 0 && higher > 0)
            {
               lim = higher + -(lower) + 1;
            }

            string[] stringslist = new string[lim];


            for (int i = 0; i < stringslist.Length; i++)
            {
                int testval = lower + i;

                if (testval % 3 == 0 && testval % 5 == 0)
                {
                    stringslist[i] = "Fizzbuzz";
                }
                else if (testval % 3 == 0)
                {
                    stringslist[i] = "Fizz";
                }
                else if (testval % 5 == 0)
                {
                    stringslist[i] = "Buzz";
                }
                else
                {
                    stringslist[i] = $"{testval}";
                }
                
            }

            return stringslist;
        }
    }
}
