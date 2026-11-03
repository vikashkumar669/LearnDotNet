string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri" };
string[,] timetable =
{
    { "Maths", "Physics", "C#", "English" },
    { "C#", "Maths", "Chemistry", "Lab" },
    { "Physics", "English", "Maths", "C#" },
    { "Chemistry", "C#", "Lab", "Maths" },
    { "English", "Maths", "C#", "Sports" }
};

Console.Write($"{"Day",-5}");
for (int p = 0; p < timetable.GetLength(1); p++)
{
    Console.Write($"{"Period " + (p + 1),-11}");
}
Console.WriteLine();

for (int d = 0; d < days.Length; d++)
{
    Console.Write($"{days[d],-5}");
    for (int p = 0; p < timetable.GetLength(1); p++)
    {
        Console.Write($"{timetable[d, p],-11}");
    }
    Console.WriteLine();
}

Console.Write("Which day (Mon-Fri)? ");
string wanted = Console.ReadLine() ?? "";
int day = Array.IndexOf(days, wanted);
if (day < 0)
{
    Console.WriteLine("No classes on that day.");
}
else
{
    int csharp = 0;
    for (int p = 0; p < timetable.GetLength(1); p++)
    {
        if (timetable[day, p] == "C#")
        {
            csharp++;
        }
    }
    Console.WriteLine($"{wanted} has {csharp} C# period(s).");
}
