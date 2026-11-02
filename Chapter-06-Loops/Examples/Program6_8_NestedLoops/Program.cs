// Program 6.8: Nested loops (multiplication grid)

Console.WriteLine("Multiplication table, 1 to 5");
Console.WriteLine("----------------------------");

for (int row = 1; row <= 5; row++)
{
    for (int column = 1; column <= 10; column++)
    {
        Console.Write($"{row * column,4}");
    }
    Console.WriteLine();   // new line after each row
}
