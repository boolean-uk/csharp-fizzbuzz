using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

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
            int length = higher - lower + 1;
            string[] result = new string[length];

            for (int i = lower; i <= higher; i++)
            {
                int index = i - lower;

                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[index] = "Fizzbuzz";
                }
                else if (i % 3 == 0)
                {
                    result[index] = "Fizz";
                } else if (i % 5 == 0)
                {
                    result[index] = "Buzz";
                }
                else
                {
                    result[index] = i.ToString();
                }
            }


            return result;
        }
    }
}
