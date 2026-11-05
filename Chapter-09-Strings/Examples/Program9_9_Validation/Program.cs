string[] names = { "Sneha Patil", "R2D2", "  ", "Mohammed Irfan" };
string[] mobiles = { "9876543210", "98765 43210", "5876543210", "987654321" };
string[] pinCodes = { "560001", "056001", "11001", "4000a1" };

Console.WriteLine("Names");
foreach (string n in names)
{
    Console.WriteLine($"  [{n}] -> {(IsValidName(n) ? "valid" : "invalid")}");
}

Console.WriteLine("Mobile numbers");
foreach (string m in mobiles)
{
    Console.WriteLine($"  [{m}] -> {(IsValidMobile(m) ? "valid" : "invalid")}");
}

Console.WriteLine("PIN codes");
foreach (string p in pinCodes)
{
    Console.WriteLine($"  [{p}] -> {(IsValidPin(p) ? "valid" : "invalid")}");
}

// A name has at least 2 letters and only letters and spaces.
bool IsValidName(string text)
{
    string name = text.Trim();
    if (name.Length < 2)
    {
        return false;
    }
    foreach (char ch in name)
    {
        if (!char.IsLetter(ch) && ch != ' ')
        {
            return false;
        }
    }
    return true;
}

// An Indian mobile number has 10 digits and starts with 6, 7, 8 or 9.
bool IsValidMobile(string text)
{
    if (text.Length != 10 || !AllDigits(text))
    {
        return false;
    }
    return text[0] >= '6' && text[0] <= '9';
}

// A PIN code has 6 digits and does not start with 0.
bool IsValidPin(string text)
{
    return text.Length == 6 && AllDigits(text) && text[0] != '0';
}

bool AllDigits(string text)
{
    foreach (char ch in text)
    {
        if (!char.IsDigit(ch))
        {
            return false;
        }
    }
    return true;
}
