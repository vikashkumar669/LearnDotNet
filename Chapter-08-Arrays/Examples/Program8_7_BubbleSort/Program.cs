int[] marks = { 64, 25, 12, 22, 11 };
Console.WriteLine($"Before : {string.Join(" ", marks)}");

for (int pass = 1; pass < marks.Length; pass++)
{
    for (int i = 0; i < marks.Length - pass; i++)
    {
        if (marks[i] > marks[i + 1])
        {
            (marks[i], marks[i + 1]) = (marks[i + 1], marks[i]);
        }
    }
    Console.WriteLine($"Pass {pass} : {string.Join(" ", marks)}");
}

Console.WriteLine($"After  : {string.Join(" ", marks)}");
