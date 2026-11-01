// Practice question 14: type of triangle (one possible answer)

Console.Write("Side 1: ");
int s1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Side 2: ");
int s2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Side 3: ");
int s3 = int.Parse(Console.ReadLine() ?? "");

if (s1 <= 0 || s2 <= 0 || s3 <= 0
    || s1 + s2 <= s3 || s1 + s3 <= s2 || s2 + s3 <= s1)
{
    Console.WriteLine("These sides cannot form a triangle.");
}
else if (s1 == s2 && s2 == s3)
{
    Console.WriteLine("Equilateral triangle");
}
else if (s1 == s2 || s2 == s3 || s1 == s3)
{
    Console.WriteLine("Isosceles triangle");
}
else
{
    Console.WriteLine("Scalene triangle");
}
