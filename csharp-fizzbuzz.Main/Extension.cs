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
                nums[i] = (i + lower).ToString();
            }

            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    string replacementString = "";
                    int number = Int32.Parse(nums[i]);
                    if (number % 3 == 0)
                    {
                        replacementString = replacementString + "Fizz";
                    }
                    if (number % 5 == 0)
                    {
                        replacementString = replacementString + "Buzz";
                    }
                    nums[i] = char.ToUpper(replacementString[0]) + replacementString.Substring(1).ToLower();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    // code to handle the exception, or simply print out the exception message, or do nothing
                };
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
