// Practice question 9: factorial (one possible answer)

int n;
while (true)
{
    Console.Write("Enter a number (0 to 20): ");
    string text = Console.ReadLine() ?? "";

    if (int.TryParse(text, out n) && n >= 0 && n <= 20)
    {
        break;
    }
    Console.WriteLine("Please type a whole number from 0 to 20.");
}

long factorial = 1;   // long, because 20! does not fit in an int
for (int i = 2; i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine($"{n}! = {factorial}");
