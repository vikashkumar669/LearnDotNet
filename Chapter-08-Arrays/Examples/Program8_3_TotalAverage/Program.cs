int[] marks = { 78, 92, 65, 88, 71, 54, 95, 60 };

int total = 0;
int highest = marks[0];
int lowest = marks[0];

foreach (int m in marks)
{
    total += m;
    if (m > highest)
    {
        highest = m;
    }
    if (m < lowest)
    {
        lowest = m;
    }
}

double average = (double)total / marks.Length;

int aboveAverage = 0;
foreach (int m in marks)
{
    if (m > average)
    {
        aboveAverage++;
    }
}

Console.WriteLine($"Marks         : {string.Join(", ", marks)}");
Console.WriteLine($"Total         : {total}");
Console.WriteLine($"Average       : {average:F2}");
Console.WriteLine($"Highest       : {highest}");
Console.WriteLine($"Lowest        : {lowest}");
Console.WriteLine($"Above average : {aboveAverage} students");
