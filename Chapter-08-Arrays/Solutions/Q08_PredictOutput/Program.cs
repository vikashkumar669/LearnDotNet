int[,] g = { { 1, 2, 3 }, { 4, 5, 6 } };
int sum = 0;
for (int r = 0; r < g.GetLength(0); r++)
{
    sum += g[r, r];
}
Console.WriteLine(sum);
Console.WriteLine(g.GetLength(1));
Console.WriteLine(g[1, 0] * g[0, 2]);
