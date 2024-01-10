using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_fizzbuzz.Main;
using NUnit.Framework;

namespace csharp_fizzbuzz.Test
{
    public class ExtensionTests
    {            
        [Test]
        public void fizzbuzz()
        {
            Extension extension = new Extension();
            String[] shouldBeOne = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.AreEqual(shouldBeOne, extension.fizzbuzz(1, 15));
        }
    }
}
