Console.Write("First number : ");
int first = int.Parse(Console.ReadLine() ?? "");
Console.Write("Second number: ");
int second = int.Parse(Console.ReadLine() ?? "");

Swap(ref first, ref second);
Console.WriteLine($"After swap: first = {first}, second = {second}");

void Swap(ref int a, ref int b)
{
    (a, b) = (b, a);
}
