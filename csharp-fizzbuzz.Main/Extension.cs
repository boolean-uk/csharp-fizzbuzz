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

            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */

            int[] ints = Enumerable.Range(lower, higher - lower + 1).ToArray();

            String[] strings = new String[ints.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                int numInt = Convert.ToInt32(ints[i]);
                switch (numInt)
                {
                    case var expression when numInt % 3 == 0 && numInt % 5 == 0:
                        strings[i] = "Fizzbuzz";
                        break;
                    case var expression when numInt % 3 == 0:
                        strings[i] = "Fizz";
                        break;
                    case var expression when numInt % 5 == 0:
                        strings[i] = "Buzz";
                        break;
                    default:
                        strings[i] = ints[i].ToString();
                        break;
                }
            }
            return strings;
        }
    }
}
