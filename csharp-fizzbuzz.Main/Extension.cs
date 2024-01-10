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
            string[] nums = new string[higher - lower + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                int num = i + lower;
                if (num % 3 == 0)
                {
                    if (num % 5 == 0)
                    {
                        nums[i] = "Fizzbuzz";
                    }
                    else
                    {
                        nums[i] = "Fizz";
                    }
                }
                else if (num % 5 == 0)
                {
                    nums[i] = "Buzz";
                }
                else
                {
                    nums[i] = num.ToString();
                }
            }

            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */



            return nums;
        }
    }
}
