// Program 6.5: The foreach loop

// A foreach loop visits every item of a collection, here the characters of a string
string word = "Bharat Mata Ki Jai";
int vowels = 0;

foreach (char letter in word)
{
    if ("aeiouAEIOU".Contains(letter))
    {
        vowels++;
    }
}
Console.WriteLine($"\"{word}\" has {vowels} vowels.");

// ... and the items of a list of values (arrays are covered fully in Chapter 8)
string[] cities = { "Delhi", "Mumbai", "Chennai", "Kolkata" };

foreach (string city in cities)
{
    Console.WriteLine($"City: {city}");
}

int[] marks = { 72, 85, 64, 91, 58 };
int total = 0;
foreach (int mark in marks)
{
    total += mark;
}
Console.WriteLine($"Total = {total}, Average = {total / (double)marks.Length}");
