// Practice question 11: prime check (one possible answer)

Console.Write("Enter a whole number: ");
int n = int.Parse(Console.ReadLine() ?? "");

bool isPrime = n >= 2;

for (int divisor = 2; divisor * divisor <= n; divisor++)
{
    if (n % divisor == 0)
    {
        isPrime = false;
        break;   // one divisor is enough
    }
}

if (isPrime)
{
    Console.WriteLine($"{n} is a prime number.");
}
else
{
    Console.WriteLine($"{n} is not a prime number.");
}
