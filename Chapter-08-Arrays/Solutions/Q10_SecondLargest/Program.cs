int[] marks = { 72, 95, 88, 95, 64, 81 };

int largest = int.MinValue;
int second = int.MinValue;

foreach (int m in marks)
{
    if (m > largest)
    {
        second = largest;
        largest = m;
    }
    else if (m > second && m < largest)
    {
        second = m;
    }
}

Console.WriteLine($"Marks          : {string.Join(", ", marks)}");
Console.WriteLine($"Largest        : {largest}");
Console.WriteLine($"Second largest : {second}");
