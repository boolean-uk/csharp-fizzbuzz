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

            string[] numbers = new string[higher - lower + 1];
            int counter = lower;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter % 3 == 0 && counter % 5 == 0)
                    numbers[i] = "Fizzbuzz";
                else if (counter % 3 == 0)
                    numbers[i] = "Fizz";
                else if (counter % 5 == 0)
                    numbers[i] = "Buzz";
                else
                    numbers[i] = counter.ToString();
                
                counter++;
            }

            return numbers;
        }
    }
}
