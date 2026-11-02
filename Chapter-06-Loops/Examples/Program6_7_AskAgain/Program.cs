// Program 6.7: Ask again until the input is valid

int marks;

while (true)
{
    Console.Write("Enter marks (0 to 100): ");
    string text = Console.ReadLine() ?? "";

    if (!int.TryParse(text, out marks))
    {
        Console.WriteLine($"'{text}' is not a whole number. Try again.");
    }
    else if (marks < 0 || marks > 100)
    {
        Console.WriteLine($"{marks} is outside the range 0 to 100. Try again.");
    }
    else
    {
        break;   // valid input: leave the loop
    }
}

Console.WriteLine($"Marks accepted: {marks}");
