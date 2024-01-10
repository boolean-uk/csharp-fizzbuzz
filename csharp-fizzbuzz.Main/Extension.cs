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

            List<int>  numberList = new List<int>();
            for (int i = lower; i <= higher; i++)
            {
                numberList.Add(i);
            }

            List<string> strings = new List<string>();

            foreach (int number in numberList)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    strings.Add("Fizzbuzz");
                }
                else if (number % 3 == 0)
                {
                    strings.Add("Fizz");
                }
                else if (number % 5 == 0)
                {
                    strings.Add("Buzz");
                }
                else
                {
                    strings.Add(number.ToString());
                }
            }


            return strings.ToArray();
        }
    }
}
