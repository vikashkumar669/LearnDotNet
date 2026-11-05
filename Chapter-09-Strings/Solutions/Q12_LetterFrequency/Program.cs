Console.Write("Enter a word or sentence: ");
string text = (Console.ReadLine() ?? "").ToLower();

int[] count = new int[26];
foreach (char ch in text)
{
    if (ch >= 'a' && ch <= 'z')
    {
        count[ch - 'a']++;
    }
}

for (int i = 0; i < count.Length; i++)
{
    if (count[i] > 0)
    {
        Console.WriteLine($"{(char)('a' + i)} : {count[i]}");
    }
}
