using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace csharp_fizzbuzz.Main
{
    public class Extension
    {
        public string[] fizzbuzz(int lower, int higher)
        {
            string[] output = new string[higher - lower + 1];

            for (int i = 0; i <= higher - lower; i++)
            {
                int value = lower + i;
                if (value% 5 == 0 && value % 3 == 0)
                {
                    output[i] = "Fizzbuzz";
                    continue;
                }
                if (value % 3 == 0)
                {
                    output[i] = "Fizz";
                    continue;
                }

                if (value % 5 == 0)
                {
                    output[i] = "Buzz";
                    continue;
                }
                output[i] = value.ToString();

            }

            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */



            return output;
        }
    }
}
