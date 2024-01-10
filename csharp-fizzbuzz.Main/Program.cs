// See https://aka.ms/new-console-template for more information
using csharp_fizzbuzz.Main;

Console.WriteLine("Hello, World!");
Core core = new Core();
String[] numsOne = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
string[] num = core.fizzbuzz(numsOne);
foreach (String s in num) { Console.WriteLine(s); }
