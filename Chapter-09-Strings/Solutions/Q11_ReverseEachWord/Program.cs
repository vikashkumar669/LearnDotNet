Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine() ?? "";

string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    words[i] = new string(letters);
}

Console.WriteLine(string.Join(" ", words));
