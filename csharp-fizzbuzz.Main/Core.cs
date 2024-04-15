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
        //
        //
        // Note: your method may throw a NumberFormatException exception if you choose to convert the strings to numbers.
        // When you convert a String to an Int, there is a chance an error could happen if the string does not contain a vaild number.
        // If, for example, the provided input looked like ["1", "2", "apple", "15"], we would get an error trying to convert "apple" into an integer
        //
        // To avoid throwin an error, you can wrap your code in a try ... catch ... block
        // try {
        //  // some operation that might throw an error
        //  // or sequence of steps that might throw an error
        // }
        // catch(Exception e) {
        //  // code to run when failing, such as returning a value from the function
        // }


        public String[] fizzbuzz(String[] nums)
        {
            throw new NotImplementedException();

            // TODO: 1. Implement a function that will look through a list of String representation of numbers and
            /*
                change the values of said array based on the rules below
                Where a number is a multiple of three (3, 6, 9, etc) the number in the array should be replaced the string "Fizz.
                Where a number is a multiple of five (5, 10, etc) the number in the array should be replaced the string "Buzz".
                Where a number is a multiple of both five AND three (15, 30, etc) the number in the array should be replaced the string "Fizzbuzz".
            * */



            return nums;
        }
    }
}
