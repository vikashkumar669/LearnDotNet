CountDown(5);
Console.WriteLine($"5! = {Factorial(5)}");
Console.WriteLine($"Sum of digits of 4821 = {SumOfDigits(4821)}");

void CountDown(int n)
{
    if (n == 0)
    {
        Console.WriteLine("Lift off!");
        return;
    }
    Console.WriteLine(n);
    CountDown(n - 1);
}

long Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    return n * Factorial(n - 1);
}

int SumOfDigits(int n)
{
    if (n < 10)
    {
        return n;
    }
    return n % 10 + SumOfDigits(n / 10);
}
