string[] typed = { "9876543210", "+91 98765 43210", "09876543210", "+91-7012345678", "12345" };

foreach (string number in typed)
{
    string result = Normalise(number);
    Console.WriteLine($"{number,-16} -> {(result == "" ? "invalid" : result)}");
}

// Returns the plain 10-digit number, or "" if it is not a valid Indian mobile number.
string Normalise(string text)
{
    string digits = text.Replace(" ", "").Replace("-", "");

    if (digits.StartsWith("+91"))
    {
        digits = digits.Substring(3);
    }
    else if (digits.Length == 11 && digits.StartsWith("0"))
    {
        digits = digits.Substring(1);
    }

    if (digits.Length != 10 || digits[0] < '6' || digits[0] > '9')
    {
        return "";
    }
    foreach (char ch in digits)
    {
        if (ch < '0' || ch > '9')
        {
            return "";
        }
    }
    return digits;
}
