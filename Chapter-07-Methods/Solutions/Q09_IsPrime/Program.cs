Console.Write("Print primes up to: ");
int limit = int.Parse(Console.ReadLine() ?? "");

for (int n = 2; n <= limit; n++)
{
    if (IsPrime(n))
    {
        Console.Write(n + " ");
    }
}
Console.WriteLine();

bool IsPrime(int number)
{
    if (number < 2)
    {
        return false;
    }
    for (int d = 2; d * d <= number; d++)
    {
        if (number % d == 0)
        {
            return false;
        }
    }
    return true;
}
