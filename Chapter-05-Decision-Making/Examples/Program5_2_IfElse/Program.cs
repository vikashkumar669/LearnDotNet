// Program 5.2: if-else (even or odd)

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even.");
}
else
{
    Console.WriteLine($"{number} is odd.");
}
