// Program 5.6: Checking input before using it

Console.Write("Enter marks (0 to 100): ");
string text = Console.ReadLine() ?? "";

if (!int.TryParse(text, out int marks))
{
    Console.WriteLine($"'{text}' is not a whole number. Please run the program again.");
}
else if (marks < 0 || marks > 100)
{
    Console.WriteLine($"{marks} is outside the range 0 to 100.");
}
else
{
    Console.WriteLine($"Marks accepted: {marks}");
}
