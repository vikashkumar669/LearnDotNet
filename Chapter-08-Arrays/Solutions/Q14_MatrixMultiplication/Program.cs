int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] b = { { 7, 8 }, { 9, 10 }, { 11, 12 } };

int rows = a.GetLength(0);
int inner = a.GetLength(1);
int cols = b.GetLength(1);
int[,] product = new int[rows, cols];

for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < cols; c++)
    {
        int sum = 0;
        for (int k = 0; k < inner; k++)
        {
            sum += a[r, k] * b[k, c];
        }
        product[r, c] = sum;
    }
}

Console.WriteLine($"A is {rows} x {inner}, B is {inner} x {cols}, A x B is {rows} x {cols}");
for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < cols; c++)
    {
        Console.Write($"{product[r, c],5}");
    }
    Console.WriteLine();
}
