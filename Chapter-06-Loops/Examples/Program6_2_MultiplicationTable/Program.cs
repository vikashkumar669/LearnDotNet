// Program 6.2: Multiplication table

Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i,2} = {n * i,3}");
}
