using csharp_fizzbuzz.Main;
using NUnit.Framework;

namespace csharp_fizzbuzz.Test
{
    public class CoreTests
    {
        Core core;
        public CoreTests()
        {
            this.core = new Core();
        }
        [Test]
        public void fizzbuzz()
        {
            String[] numsOne = { "1", "2", "3", "apple", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            String[] shouldBeOne = { "1", "2", "Fizz", "apple", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "Fizzbuzz" };
            Assert.True(shouldBeOne.SequenceEqual(this.core.fizzbuzz(numsOne)));
        }

    }
}