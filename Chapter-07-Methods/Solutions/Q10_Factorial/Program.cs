Console.Write("Enter a number from 0 to 20: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{n}! by loop      = {FactorialLoop(n)}");
Console.WriteLine($"{n}! by recursion = {FactorialRecursive(n)}");

long FactorialLoop(int number)
{
    long result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

long FactorialRecursive(int number)
{
    return number <= 1 ? 1 : number * FactorialRecursive(number - 1);
}
