Console.WriteLine(Mystery(4));
Console.WriteLine(Mystery(1));

int Mystery(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    return n + Mystery(n - 2);
}
