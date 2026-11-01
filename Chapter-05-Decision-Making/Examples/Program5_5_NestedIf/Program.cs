// Program 5.5: Nested if (admission check)
// The rules are example rules, not those of a real university.

Console.Write("Percentage in Class 12 : ");
double percentage = double.Parse(Console.ReadLine() ?? "");

Console.Write("Studied Maths (y/n)    : ");
string answer = Console.ReadLine() ?? "";
bool hasMaths = answer == "y" || answer == "Y";

if (percentage >= 50)
{
    if (hasMaths)
    {
        Console.WriteLine("Eligible for B.Tech and BCA.");
    }
    else
    {
        Console.WriteLine("Eligible for BCA. B.Tech needs Maths in Class 12.");
    }
}
else
{
    Console.WriteLine("Not eligible: a minimum of 50% is required.");
}
