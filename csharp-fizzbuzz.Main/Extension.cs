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

            string[] nums = new string[higher - lower + 1];

            IEnumerable<int> values = Enumerable.Range(lower, higher - lower + 1);

            int i = 0;
            foreach ( int number in values )
            {
                try
                {
                    switch (number)
                    {
                        case var expression when (number % 15 == 0):
                            nums[i] = "Fizzbuzz";
                            break;
                        case var expression when (number % 3 == 0):
                            nums[i] = "Fizz";
                            break;
                        case var expression when (number % 5 == 0):
                            nums[i] = "Buzz";
                            break;
                        default:
                            nums[i] = number.ToString();
                            break;
                    }
                }
                catch (Exception e) { }
                i++;
            }

            return nums;
        }
    }
}
