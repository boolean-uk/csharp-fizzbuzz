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
            string[] stringnumbers = new string[higher - lower + 1];
            int[] intnumbers = new int[higher - lower + 1];
            for (int i = 0; i < intnumbers.Length; i++)
            {
                intnumbers[i] = lower + i;
                stringnumbers[i] = Convert.ToString(intnumbers[i]);
            }

            for (int i = 0; i < stringnumbers.Length; i++)
            {
                int integer = int.Parse(stringnumbers[i]);
                if (integer % 3 == 0 && integer % 5 == 0)
                {
                    stringnumbers[i] = "Fizzbuzz";
                }
                else if (integer % 3 == 0)
                {
                    stringnumbers[i] = "Fizz";
                }
                else if (integer % 5 == 0)
                {
                    stringnumbers[i] = "Buzz";
                }
            }
            return stringnumbers;
        }
    }
}
