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
            List<string> liste = new List<string>();

            for (int i = lower; i <= higher; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    liste.Add("Fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    liste.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    liste.Add("Buzz");
                }
                else
                {
                    liste.Add(i.ToString());
                }
            }

            return liste.ToArray();
        }
    }

}

