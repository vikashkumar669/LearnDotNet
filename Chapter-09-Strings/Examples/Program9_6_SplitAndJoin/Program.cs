string record = "Ananya Iyer,BCA,82,76,91";

string[] parts = record.Split(',');

Console.WriteLine($"Pieces : {parts.Length}");
Console.WriteLine($"Name   : {parts[0]}");
Console.WriteLine($"Course : {parts[1]}");

int total = 0;
for (int i = 2; i < parts.Length; i++)
{
    total += int.Parse(parts[i]);
}
Console.WriteLine($"Total  : {total}");

string sentence = "India is my country";
string[] words = sentence.Split(' ');
Console.WriteLine($"Words  : {words.Length}");
Console.WriteLine($"Last word: {words[words.Length - 1]}");

Array.Reverse(words);
Console.WriteLine($"Reversed order: {string.Join(" ", words)}");

string[] subjects = { "C#", "DBMS", "Maths" };
Console.WriteLine($"Subjects: {string.Join(", ", subjects)}");

string messy = "Pune,,Nagpur, ,Nashik";
string[] cities = messy.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
Console.WriteLine($"Cities: {string.Join(" | ", cities)} ({cities.Length})");
