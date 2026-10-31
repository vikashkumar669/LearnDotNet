// Practice question 13: average of three marks (one possible answer)

Console.Write("Marks in subject 1: ");
int m1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Marks in subject 2: ");
int m2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Marks in subject 3: ");
int m3 = int.Parse(Console.ReadLine() ?? "");

int total = m1 + m2 + m3;
double average = total / 3.0;

Console.WriteLine($"Total   : {total}");
Console.WriteLine($"Average : {average:F2}");
Console.WriteLine($"Passed  : {average >= 40}");
