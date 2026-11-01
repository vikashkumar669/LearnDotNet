// Program 5.1: The if statement

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine() ?? "");

if (age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}

Console.WriteLine("Thank you for checking.");
