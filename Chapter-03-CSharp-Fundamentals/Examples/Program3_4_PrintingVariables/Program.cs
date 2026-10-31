// Program 3.4: Printing variables

string name = "Aarav";
int roll = 21;
double cgpa = 8.456;
char grade = 'A';
bool isHosteler = false;
decimal fee = 45000.50m;

Console.WriteLine("Name: " + name);
Console.WriteLine($"Roll No: {roll}");
Console.WriteLine($"CGPA: {cgpa:F2}");
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"Hosteler: {isHosteler}");
Console.WriteLine($"Fee: Rs. {fee:F2}");
Console.WriteLine($"{name} (Roll No. {roll}) scored grade {grade}.");
