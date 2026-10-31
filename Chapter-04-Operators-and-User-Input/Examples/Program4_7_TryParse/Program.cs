// Program 4.7: Safe conversion with TryParse

Console.Write("Enter your age: ");
string text = Console.ReadLine() ?? "";

bool isNumber = int.TryParse(text, out int age);

Console.WriteLine($"Valid number : {isNumber}");
Console.WriteLine($"Age          : {age}");
