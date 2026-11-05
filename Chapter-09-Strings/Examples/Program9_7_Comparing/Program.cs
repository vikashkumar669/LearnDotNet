string a = "Delhi";
string b = "Delhi";
string c = "delhi";

Console.WriteLine($"a == b : {a == b}");
Console.WriteLine($"a == c : {a == c}");
Console.WriteLine($"a.Equals(c, OrdinalIgnoreCase) : {a.Equals(c, StringComparison.OrdinalIgnoreCase)}");

Console.WriteLine();
Console.WriteLine($"Compare(\"Amit\", \"Bina\") : {string.Compare("Amit", "Bina")}");
Console.WriteLine($"Compare(\"Bina\", \"Amit\") : {string.Compare("Bina", "Amit")}");
Console.WriteLine($"Compare(\"Amit\", \"Amit\") : {string.Compare("Amit", "Amit")}");

Console.WriteLine();
string[] names = { "Rohan", "aditi", "Kavya", "Arjun", "meera" };
Array.Sort(names, StringComparer.OrdinalIgnoreCase);
Console.WriteLine($"Sorted : {string.Join(", ", names)}");

Console.WriteLine();
Console.Write("Enter the password hint city: ");
string hint = (Console.ReadLine() ?? "").Trim();

if (hint.Equals("Jaipur", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Correct hint.");
}
else
{
    Console.WriteLine("Wrong hint.");
}
