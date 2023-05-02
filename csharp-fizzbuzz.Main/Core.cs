﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
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
            //foreach (String s in nums)
            //{
            //    try { 
            //        int number = Int32.Parse(s); 
            //    }
            //    catch { }

            /*
             * need to add  
             * int num;
                bool isParsable = Int32.TryParse(nums[i], out num);

                if (isParsable)
            to make sure if the string contains something else than a number it doesn't crash
             */
            int[] numberArray = new int[nums.Length];
            for (int i = 0; i< nums.Length; i++)
            {
                numberArray[i] = int.Parse(nums[i]);
            }
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 3 == 0 && numberArray[i] % 5 == 0)
                {
                    nums[i]= "Fizzbuzz";
                    //nums[i].Replace(nums[i], "Fizzbuzz");
                    //replace with Fizzbuzz in nums
                    //need to put this one first?
                }
                else if (numberArray[i] % 3 == 0)
                {
                    nums[i] = "Fizz";
                    //nums[i].Replace(nums[i], "Fizz");
                    //replace with Fizz in nums
                }
                else if (numberArray[i] % 5 == 0)
                {
                    nums[i] = "Buzz";
                    //nums[i].Replace(nums[i], "Buzz");
                    //replace with Buzz in nums
                }
                
            }

            return nums;
        }
    }
}