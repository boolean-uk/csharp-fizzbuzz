using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fizzbuzz.Main
{
    //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
            Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
            Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
            Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */
    public class Extension
    {
        public string[] fizzbuzz(int lower, int higher)
        {
            int[] numbers = Enumerable.Range(lower, higher - lower + 1).ToArray();
            string[] result = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[i].ToString();
                try
                {
                    if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
                    {
                        result[i] = "Fizzbuzz";
                    }
                    else if (numbers[i] % 5 == 0)
                    {
                        result[i] = "Buzz";
                    }
                    else if (numbers[i] % 3 == 0)
                    {
                        result[i] = "Fizz";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return result;

        }
    }
}
