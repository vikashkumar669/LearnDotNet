// Practice question 13: simple calculator with switch (one possible answer)

Console.Write("First number     : ");
double first = double.Parse(Console.ReadLine() ?? "");
Console.Write("Operator (+-*/)  : ");
string op = Console.ReadLine() ?? "";
Console.Write("Second number    : ");
double second = double.Parse(Console.ReadLine() ?? "");

switch (op)
{
    case "+":
        Console.WriteLine($"Result           : {first + second}");
        break;
    case "-":
        Console.WriteLine($"Result           : {first - second}");
        break;
    case "*":
        Console.WriteLine($"Result           : {first * second}");
        break;
    case "/":
        if (second == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine($"Result           : {first / second}");
        }
        break;
    default:
        Console.WriteLine($"Unknown operator '{op}'.");
        break;
}
