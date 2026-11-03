int sq = Square(9);
Console.WriteLine($"Square of 9 = {sq}");

int bigger = Max(42, 17);
Console.WriteLine($"Larger of 42 and 17 = {bigger}");

Console.WriteLine($"Is 28 even? {IsEven(28)}");
Console.WriteLine($"Is 15 even? {IsEven(15)}");

int[] marks = { 91, 78, 64, 45, 32 };
foreach (int m in marks)
{
    Console.WriteLine($"{m} marks -> grade {GetGrade(m)}");
}

int Square(int number)
{
    return number * number;
}

int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    return b;
}

bool IsEven(int number)
{
    return number % 2 == 0;
}

string GetGrade(int marks)
{
    if (marks >= 90) return "A";
    if (marks >= 75) return "B";
    if (marks >= 60) return "C";
    if (marks >= 40) return "D";
    return "F";
}
