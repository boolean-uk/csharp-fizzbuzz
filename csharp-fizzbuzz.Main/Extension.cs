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
            List<string> number = new List<string>();
            for (int i = lower; i <= higher; i++)
            {
                if ((i) % 3 == 0 && (i) % 5 == 0)
                    number.Add("Fizzbuzz");
                else if ((i) % 3 == 0)
                    number.Add("Fizz");
                else if ((i) % 5 == 0)
                    number.Add("Buzz");
                else
                    number.Add((i).ToString());
            }

            return number.ToArray();

            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */



            
        }
    }
}
