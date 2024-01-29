// See https://aka.ms/new-console-template for more information

String[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

for (int i = 0; i < nums.Length; i++)
{
    string result = "";
    int curNum = int.Parse(nums[i]);

    if (curNum % 3 == 0) result += ("Fizz");
    if (curNum % 5 == 0) result += ("Buzz");

    if (result != "") nums[i] = result;
}

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i] + ", ");
}
