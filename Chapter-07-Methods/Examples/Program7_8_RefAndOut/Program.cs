int a = 10;
int b = 20;
Console.WriteLine($"Before swap : a = {a}, b = {b}");
Swap(ref a, ref b);
Console.WriteLine($"After swap  : a = {a}, b = {b}");

string[] inputs = { "21", "abc", "-4" };
foreach (string text in inputs)
{
    if (TryReadAge(text, out int age))
    {
        Console.WriteLine($"\"{text}\" is a valid age: {age}");
    }
    else
    {
        Console.WriteLine($"\"{text}\" is not a valid age.");
    }
}

Divide(47, 5, out int quotient, out int remainder);
Console.WriteLine($"47 / 5 : quotient = {quotient}, remainder = {remainder}");

void Swap(ref int first, ref int second)
{
    int temp = first;
    first = second;
    second = temp;
}

bool TryReadAge(string text, out int age)
{
    if (int.TryParse(text, out age) && age >= 0 && age <= 120)
    {
        return true;
    }
    age = 0;
    return false;
}

void Divide(int dividend, int divisor, out int quotient, out int remainder)
{
    quotient = dividend / divisor;
    remainder = dividend % divisor;
}
