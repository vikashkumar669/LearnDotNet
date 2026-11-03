string[] students = { "Aarav", "Diya", "Kabir" };
string[] subjects = { "Maths", "Phys", "Chem", "Eng" };

int[,] marks =
{
    { 85, 78, 92, 70 },
    { 90, 88, 76, 84 },
    { 67, 72, 80, 91 }
};

int rows = marks.GetLength(0);
int cols = marks.GetLength(1);
Console.WriteLine($"Rows = {rows}, columns = {cols}, cells = {marks.Length}");
Console.WriteLine($"Diya's Chemistry marks = {marks[1, 2]}");
Console.WriteLine();

Console.Write($"{"Student",-8}");
foreach (string subject in subjects)
{
    Console.Write($"{subject,6}");
}
Console.WriteLine($"{"Total",7}");

for (int r = 0; r < rows; r++)
{
    Console.Write($"{students[r],-8}");
    int total = 0;
    for (int c = 0; c < cols; c++)
    {
        Console.Write($"{marks[r, c],6}");
        total += marks[r, c];
    }
    Console.WriteLine($"{total,7}");
}

Console.Write($"{"Average",-8}");
for (int c = 0; c < cols; c++)
{
    int sum = 0;
    for (int r = 0; r < rows; r++)
    {
        sum += marks[r, c];
    }
    Console.Write($"{(double)sum / rows,6:F1}");
}
Console.WriteLine();
