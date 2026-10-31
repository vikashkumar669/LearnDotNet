// Program 4.6: Adding two numbers typed by the user

Console.Write("Enter first number : ");
int first = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter second number: ");
int second = Convert.ToInt32(Console.ReadLine());

int sum = first + second;
Console.WriteLine($"Sum = {sum}");
