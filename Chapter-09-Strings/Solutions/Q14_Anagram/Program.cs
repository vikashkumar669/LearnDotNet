Console.Write("First word : ");
string first = Console.ReadLine() ?? "";
Console.Write("Second word: ");
string second = Console.ReadLine() ?? "";

string a = SortedLetters(first);
string b = SortedLetters(second);

Console.WriteLine($"Sorted letters: {a} and {b}");
Console.WriteLine(a == b ? "They are anagrams." : "They are not anagrams.");

string SortedLetters(string word)
{
    char[] letters = word.Replace(" ", "").ToLower().ToCharArray();
    Array.Sort(letters);
    return new string(letters);
}
