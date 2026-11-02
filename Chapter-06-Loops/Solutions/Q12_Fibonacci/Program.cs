// Practice question 12: Fibonacci series (one possible answer)

Console.Write("How many terms? ");
int n = int.Parse(Console.ReadLine() ?? "");

long first = 0;
long second = 1;

for (int i = 1; i <= n; i++)
{
    Console.Write(first + " ");
    long next = first + second;
    first = second;
    second = next;
}
Console.WriteLine();
