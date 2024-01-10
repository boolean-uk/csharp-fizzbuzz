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
            //throw new NotImplementedException();

            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */
            //throw new NumberFormatException();
            List<string> list1 = new List<string>();

            for (int i = 0; i <  higher - lower +1; i++)
            {
                int number = i + lower;
                if (number % 3 == 0 && number % 5 == 0)
                {
                    list1.Add("Fizzbuzz");
                }
                else if (number % 3 == 0)
                {
                    list1.Add("Fizz");
                }
                else if (number % 5 == 0)
                {
                    list1.Add("Buzz");
                }
                else
                {
                    list1.Add(Convert.ToString(number));
                    //list1.Add(number.ToString());
                }

            }

            return list1.ToArray(); // Converta list to an array
        }
    }
}
