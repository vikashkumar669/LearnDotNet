int[] marks = new int[5];
marks[0] = 78;
marks[1] = 92;
marks[2] = 65;
marks[3] = 88;
marks[4] = 71;

Console.WriteLine($"First mark  : {marks[0]}");
Console.WriteLine($"Third mark  : {marks[2]}");
Console.WriteLine($"Last mark   : {marks[marks.Length - 1]}");
Console.WriteLine($"Length      : {marks.Length}");

marks[2] = 70;
Console.WriteLine($"Third mark after correction: {marks[2]}");

string[] cities = { "Delhi", "Mumbai", "Chennai", "Kolkata" };
Console.WriteLine($"{cities.Length} cities, the first is {cities[0]}");

double[] prices = new double[3];
bool[] present = new bool[3];
string[] names = new string[2];
Console.WriteLine($"Default values: {prices[0]}, {present[0]}, {names[0] == null}");
