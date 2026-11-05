Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine() ?? "";

string letters = "";
foreach (char ch in sentence)
{
    if (char.IsLetterOrDigit(ch))
    {
        letters += char.ToLower(ch);
    }
}

bool isPalindrome = true;
for (int i = 0; i < letters.Length / 2; i++)
{
    if (letters[i] != letters[letters.Length - 1 - i])
    {
        isPalindrome = false;
        break;
    }
}

Console.WriteLine($"Letters only: {letters}");
Console.WriteLine(isPalindrome ? "It is a palindrome." : "It is not a palindrome.");
