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
            //throw new NotImplementedException();
            int lenghtOfArray = (higher - lower + 1);

            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */
            string[] arrayToReturn = new string[lenghtOfArray];

            for (int i = 0; i < lenghtOfArray; i++)
            {
                int currentNumer = lower + i;

                if (currentNumer % 3 == 0 && currentNumer % 5 == 0)
                {
                    arrayToReturn[i] = "Fizzbuzz";

                }

                else if (currentNumer % 3 == 0)
                {
                    arrayToReturn[i] = "Fizz";
                }

                else if ((currentNumer % 5 == 0))
                {
                    arrayToReturn[i] = "Buzz";
                }

                else
                {
                    arrayToReturn[i] = currentNumer.ToString();
                }

            }


            return arrayToReturn;
        }
    }
}
