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
            int[] range = Enumerable.Range(lower, higher).ToArray();
            string[] nums = range.Select(x => x.ToString()).ToArray();

            int i = 0;
            foreach (string s in nums)
            {
                int stringAsNumber = Convert.ToInt32(s);
                if (stringAsNumber % 3 == 0 && stringAsNumber % 5 == 0)
                {
                    nums[i] = "Fizzbuzz";
                }
                else if (stringAsNumber % 3 == 0)
                {
                    nums[i] = "Fizz";
                }
                else if (stringAsNumber % 5 == 0)
                {
                    nums[i] = "Buzz";
                }
                i++;
            }

            return nums;
        }
    }
}
