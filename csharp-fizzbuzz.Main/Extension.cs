﻿namespace csharp_fizzbuzz.Main
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
            String[] strings = new string[higher - lower + 1];
            for (int i = lower; i <= higher; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    strings[i - lower] = "Fizzbuzz";
                }
                else if (i % 3 == 0)
                {
                    strings[i - lower] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    strings[i - lower] = "Buzz";
                }
                else
                {
                    strings[i - lower] = i.ToString();
                }
            }

            return strings;
        }
    }
}
