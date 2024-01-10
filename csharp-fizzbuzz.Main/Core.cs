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
            for (int i = 0; i < nums.Length; i++)
            {
                
                    int num = int.Parse(nums[i]);

                    if (num % 3 == 0 && num % 5 == 0)
                    {
                        nums[i] = "Fizzbuzz";
                    }
                    else if (num % 3 == 0)
                    {
                        nums[i] = "Fizz";
                    }
                    else if (num % 5 == 0)
                    {
                        nums[i] = "Buzz";
                    }
               
                
                                  
            }

            return nums;
        }
    }
}