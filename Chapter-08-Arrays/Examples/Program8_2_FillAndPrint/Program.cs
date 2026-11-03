Console.Write("How many students? ");
int count = int.Parse(Console.ReadLine() ?? "");
int[] marks = new int[count];

for (int i = 0; i < marks.Length; i++)
{
    Console.Write($"Marks of student {i + 1}: ");
    marks[i] = int.Parse(Console.ReadLine() ?? "");
}

Console.WriteLine("Using for (position and value):");
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine($"  marks[{i}] = {marks[i]}");
}

Console.Write("Using foreach (values only): ");
foreach (int m in marks)
{
    Console.Write(m + " ");
}
Console.WriteLine();

Console.Write("In reverse order: ");
for (int i = marks.Length - 1; i >= 0; i--)
{
    Console.Write(marks[i] + " ");
}
Console.WriteLine();
