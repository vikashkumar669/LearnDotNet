// Practice question 11: largest of three numbers (one possible answer)

Console.Write("First number  : ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Second number : ");
int b = int.Parse(Console.ReadLine() ?? "");
Console.Write("Third number  : ");
int c = int.Parse(Console.ReadLine() ?? "");

int largest;

if (a >= b && a >= c)
{
    largest = a;
}
else if (b >= c)
{
    largest = b;
}
else
{
    largest = c;
}

Console.WriteLine($"Largest       : {largest}");
