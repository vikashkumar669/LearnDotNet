string sentence = "Chandrayaan 3 landed in 2023";

Console.WriteLine($"Sentence : {sentence}");
Console.WriteLine($"Length   : {sentence.Length}");
Console.WriteLine($"First    : {sentence[0]}");
Console.WriteLine($"Last     : {sentence[sentence.Length - 1]}");

int vowels = 0, consonants = 0, digits = 0, spaces = 0;

foreach (char ch in sentence)
{
    if (char.IsDigit(ch))
    {
        digits++;
    }
    else if (char.IsWhiteSpace(ch))
    {
        spaces++;
    }
    else if (char.IsLetter(ch))
    {
        char lower = char.ToLower(ch);
        if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
        {
            vowels++;
        }
        else
        {
            consonants++;
        }
    }
}

Console.WriteLine($"Vowels {vowels}, consonants {consonants}, digits {digits}, spaces {spaces}");

Console.Write("Reversed : ");
for (int i = sentence.Length - 1; i >= 0; i--)
{
    Console.Write(sentence[i]);
}
Console.WriteLine();
