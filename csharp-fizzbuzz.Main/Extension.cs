using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fizzbuzz.Main
{
        public class Extension
        {
        private Core core = new Core(); // keeping it private to practice so only methods in the extension can acces it. -> encapsulation
            public string[] fizzbuzz(int lower, int higher)
            {
            // Used https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range?view=net-7.0 for generating the array low to high
            int[] numbers = Enumerable.Range(lower, higher - lower + 1).ToArray();
            // Used https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select?view=net-7.0 for converting int to string array
            string[] stringNumbers = numbers.Select(n => n.ToString()).ToArray();
            // Using fizzbuzz from core and returning it
            return core.fizzbuzz(stringNumbers);

        }
    }
    }

