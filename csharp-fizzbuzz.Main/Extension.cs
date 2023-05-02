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

            int[] results = new int[(higher - lower) +1];
            int counter = 0;
            for (int i = lower; i<= higher; i++)
            {
                results[counter] = i;
                counter++;
            }
            string[] stringArray = new string[results.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = results[i].ToString();
            }

            for (int i=0; i < stringArray.Length; i++)
            {
                if (results[i] % 3 == 0 && results[i] % 5 == 0)
                {
                    stringArray[i] = "Fizzbuzz";
                }
                else if(results[i] % 3 == 0)
                {
                    stringArray[i] = "Fizz";
                }
                else if (results[i] % 5 == 0)
                {
                    stringArray[i] = "Buzz";
                }
            }

            return stringArray;
        }
    }
}
