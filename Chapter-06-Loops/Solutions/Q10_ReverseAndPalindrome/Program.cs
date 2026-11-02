// Practice question 10: reverse of a number and palindrome check (one possible answer)

Console.Write("Enter a positive whole number: ");
int number = int.Parse(Console.ReadLine() ?? "");

int original = number;
int reversed = 0;

while (number > 0)
{
    reversed = reversed * 10 + number % 10;   // add the last digit to the reverse
    number /= 10;                             // remove the last digit
}

Console.WriteLine($"Reverse of {original} is {reversed}");

if (reversed == original)
{
    Console.WriteLine("It is a palindrome.");
}
else
{
    Console.WriteLine("It is not a palindrome.");
}
