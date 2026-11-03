int[] marks = { 78, 92, 65, 88, 71 };

PrintArray("Marks", marks);
Console.WriteLine($"Total      : {Sum(marks)}");
Console.WriteLine($"Highest    : {Max(marks)}");

int[] withGrace = AddGrace(marks, 10);
PrintArray("With grace", withGrace);
PrintArray("Original", marks);

void PrintArray(string label, int[] values)
{
    Console.WriteLine($"{label,-11}: {string.Join(" ", values)}");
}

int Sum(int[] values)
{
    int total = 0;
    foreach (int v in values)
    {
        total += v;
    }
    return total;
}

int Max(int[] values)
{
    int biggest = values[0];
    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > biggest)
        {
            biggest = values[i];
        }
    }
    return biggest;
}

int[] AddGrace(int[] values, int grace)
{
    int[] result = new int[values.Length];
    for (int i = 0; i < values.Length; i++)
    {
        result[i] = Math.Min(values[i] + grace, 100);
    }
    return result;
}
