using System.Text;

// Every += makes a brand new string
string line = "Hi";
string before = line;
line += " there";
Console.WriteLine($"before = {before}, line = {line}");
Console.WriteLine($"Same object? {ReferenceEquals(before, line)}");

// StringBuilder changes one buffer in place
StringBuilder table = new StringBuilder();
for (int i = 1; i <= 5; i++)
{
    table.Append($"7 x {i} = {7 * i}");
    table.AppendLine();
}
Console.Write(table.ToString());

StringBuilder sb = new StringBuilder("Kolkata");
sb.Insert(0, "City: ");
sb.Append(", West Bengal");
sb.Replace("City", "Place");
Console.WriteLine(sb.ToString());

// Build a string of 1 to 10 separated by commas
StringBuilder numbers = new StringBuilder();
for (int n = 1; n <= 10; n++)
{
    if (numbers.Length > 0)
    {
        numbers.Append(", ");
    }
    numbers.Append(n);
}
Console.WriteLine(numbers);
Console.WriteLine($"Length: {numbers.Length}");
