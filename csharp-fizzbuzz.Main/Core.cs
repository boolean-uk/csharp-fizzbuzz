using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fizzbuzz.Main
{
    public class Core
    {
        // Since an array can only contain values of a single type, we're providing an array of strings for you to run logic on.
        // You'll need to convert each string into a number to solve this exercise
        // For example, the tests will provide an input such as ["1", "2", "10", "15"] and will expect an output of ["1", "2", "Buzz", "Fizzbuzz"]
        // Notice the "throws NumberFormatException" on the method signature.
        // As you will need to convert a String to an Int, there is a chance an error could happen.
        // If, for example, the provided input looked like ["1", "2", "apple", "15"], we would get an error trying to convert "apple" into an integer


        public String[] fizzbuzz(String[] nums)
        {
           

            // TODO: 1. Implement a function that will look through a list of String representation of numbers and
            /* 
                change the values of said array based on the rules below
                Where a number is a multiple of three (3, 6, 9, etc) the number in the array should be replaced the string "Fizz.
                Where a number is a multiple of five (5, 10, etc) the number in the array should be replaced the string "Buzz".
                Where a number is a multiple of both five AND three (15, 30, etc) the number in the array should be replaced the string "Fizzbuzz".
            * */
            int current = 0;
            for(int i=0; i<nums.Length; i++)
            {
                try
                {
                    current = int.Parse(nums[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (current % 3 == 0 && current % 5 == 0)
                {
                    nums[i] = "Fizzbuzz";
                } else if (current % 3 == 0)
                {
                    nums[i] = "Fizz";
                } else if (current%5 == 0)
                {
                    nums[i] = "Buzz";
                }

            }



            return nums;
        }
    }
}