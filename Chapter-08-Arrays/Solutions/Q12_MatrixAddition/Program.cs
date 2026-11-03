int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] b = { { 9, 8, 7 }, { 6, 5, 4 } };
int[,] sum = new int[2, 3];

for (int r = 0; r < a.GetLength(0); r++)
{
    for (int c = 0; c < a.GetLength(1); c++)
    {
        sum[r, c] = a[r, c] + b[r, c];
    }
}

Console.WriteLine("A + B =");
for (int r = 0; r < sum.GetLength(0); r++)
{
    for (int c = 0; c < sum.GetLength(1); c++)
    {
        Console.Write($"{sum[r, c],4}");
    }
    Console.WriteLine();
}
