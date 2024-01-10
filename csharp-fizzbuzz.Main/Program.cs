// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void fizzbuzz(int lower, int higher)
{
    //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
    /* 
        Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
        Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
        Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
    * */
    string[] strings = new string[higher - lower+1];
    for (int i = 0; i < strings.Length; i++)
    {
        strings[i] = (lower + i).ToString();
    }


    for (int i = 0; i < strings.Length; i++)
    {
        int number = int.Parse(strings[i]);
        if (number % 3 == 0 && number % 5 == 0)
        {
            strings[i] = "Fizzbuzz";
        }
        else if (number % 3 == 0)
        {
            strings[i] = "Fizz";

        }
        else if (number % 5 == 0)
        {
            strings[i] = "Buzz";
        }
    }


    Array.ForEach(strings, Console.WriteLine);
}

fizzbuzz(1, 15);

