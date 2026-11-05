Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine() ?? "";

string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Words: {words.Length}");

string longest = "";
foreach (string word in words)
{
    if (word.Length > longest.Length)
    {
        longest = word;
    }
}
Console.WriteLine($"Longest word: {longest} ({longest.Length} letters)");
