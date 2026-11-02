// Program 6.9: Star patterns

const int Rows = 5;

Console.WriteLine("Right triangle:");
for (int row = 1; row <= Rows; row++)
{
    for (int star = 1; star <= row; star++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Pyramid:");
for (int row = 1; row <= Rows; row++)
{
    for (int space = 1; space <= Rows - row; space++)
    {
        Console.Write(" ");
    }
    for (int star = 1; star <= 2 * row - 1; star++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Number triangle:");
for (int row = 1; row <= Rows; row++)
{
    for (int number = 1; number <= row; number++)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}
