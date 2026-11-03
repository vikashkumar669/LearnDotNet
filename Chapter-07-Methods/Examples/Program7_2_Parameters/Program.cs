Greet("Aarav", "Delhi University");
Greet("Diya", "Pune University");

PrintTable(5, 5);
PrintTable(12, 3);

void Greet(string name, string college)
{
    Console.WriteLine($"Welcome {name} to {college}!");
}

void PrintTable(int number, int rounds)
{
    for (int i = 1; i <= rounds; i++)
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
    }
}
