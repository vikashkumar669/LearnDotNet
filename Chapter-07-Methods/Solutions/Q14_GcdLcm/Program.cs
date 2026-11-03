Console.Write("First number : ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Second number: ");
int b = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"GCD of {a} and {b} = {Gcd(a, b)}");
Console.WriteLine($"LCM of {a} and {b} = {a / Gcd(a, b) * b}");

int Gcd(int x, int y)
{
    if (y == 0)
    {
        return x;
    }
    return Gcd(y, x % y);
}
