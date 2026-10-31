// Practice question 11: simple interest (one possible answer)

Console.Write("Principal (Rs.)   : ");
decimal principal = decimal.Parse(Console.ReadLine() ?? "");

Console.Write("Rate (% per year) : ");
decimal rate = decimal.Parse(Console.ReadLine() ?? "");

Console.Write("Time (years)      : ");
int years = int.Parse(Console.ReadLine() ?? "");

decimal interest = principal * rate * years / 100;
Console.WriteLine($"Simple interest   : Rs. {interest:F2}");
Console.WriteLine($"Amount            : Rs. {principal + interest:F2}");
