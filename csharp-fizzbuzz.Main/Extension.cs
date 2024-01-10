using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fizzbuzz.Main
{
    public class Extension
    {
        public string[] fizzbuzz(int lower, int higher)
        {
             string [] nums = new string [higher - lower + 1];


            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = (lower+i).ToString();
            }
            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */


            for (int i = 0; i < nums.Length; i++)
            {
                int currentValue;
                StringBuilder sb = new StringBuilder();

                //parse
                try
                {
                    currentValue = int.Parse(nums[i]);
                }
                catch (Exception e) { continue; }

                if (currentValue % 3 == 0 && currentValue % 5 == 0)
                {
                    sb.Append("Fizzbuzz");
                    nums[i] = sb.ToString();
                    continue;
                };

                if (currentValue % 3 == 0) { sb.Append("Fizz"); };
                if (currentValue % 5 == 0) { sb.Append("Buzz"); };
                bool pause = true;
                if (sb.ToString().Length > 0) { nums[i] = sb.ToString(); }



            }


            return nums;
        }
    }
}
