// Practice question 12: Celsius to Fahrenheit (one possible answer)

Console.Write("Temperature in Celsius: ");
double celsius = double.Parse(Console.ReadLine() ?? "");

double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine($"{celsius} C = {fahrenheit} F");
