// Program 5.8: Switch expressions and patterns

Console.Write("Enter month number (1-12): ");
int month = int.Parse(Console.ReadLine() ?? "");

string season = month switch
{
    3 or 4 or 5 => "Summer",
    >= 6 and <= 9 => "Monsoon",
    10 or 11 => "Post-monsoon",
    12 or 1 or 2 => "Winter",
    _ => "Invalid month"
};
Console.WriteLine($"Season: {season}");

Console.Write("Enter passenger age: ");
int age = int.Parse(Console.ReadLine() ?? "");

decimal fare = 500m;
decimal payable = age switch
{
    < 5 => 0m,
    < 12 => fare / 2,
    >= 60 => fare * 0.6m,
    _ => fare
};
Console.WriteLine($"Fare: Rs. {fare:F2}, payable: Rs. {payable:F2}");
