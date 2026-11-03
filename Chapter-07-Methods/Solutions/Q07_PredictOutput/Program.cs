int x = 5;
Change(x);
Console.WriteLine(x);
Console.WriteLine(Change(x));

int Change(int x)
{
    x = x * 3;
    return x + 1;
}
