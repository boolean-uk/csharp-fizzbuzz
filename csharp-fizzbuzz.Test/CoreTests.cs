using csharp_fizzbuzz.Main;
using NUnit.Framework;

namespace csharp_fizzbuzz.Test
{
    public class CoreTests
    {
         
        [Test]
        public void fizzbuzz()
        {
            Core core = new Core();
            String[] numsOne = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            String[] shouldBeOne = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.True(shouldBeOne.SequenceEqual(core.fizzbuzz(numsOne)));
        }

    }
}