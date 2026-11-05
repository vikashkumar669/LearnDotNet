string[] p = "10-20-30".Split('-');
Console.WriteLine(p[0] + p[1]);
Console.WriteLine(int.Parse(p[0]) + int.Parse(p[1]));
Console.WriteLine(string.Join("+", p));
Console.WriteLine("abc".CompareTo("abd"));
Console.WriteLine("  Hi  ".Trim().Length);
