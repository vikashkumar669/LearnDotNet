using System.Text;

Console.WriteLine("=== College Registration Desk ===");

string name = ReadValid("Full name      : ", "name", "Use letters and spaces only, at least 2 letters.");
string mobile = ReadValid("Mobile number  : ", "mobile", "Enter 10 digits starting with 6, 7, 8 or 9.");
string pin = ReadValid("PIN code       : ", "pin", "Enter 6 digits; the first digit cannot be 0.");
string email = ReadValid("Email          : ", "email", "Enter an email like name@college.ac.in.");
string course = ReadValid("Course (BCA/BSC/BTECH): ", "course", "Choose BCA, BSC or BTECH.");
string serial = ReadValid("Serial number (1-999): ", "serial", "Enter a number from 1 to 999.");

string rollNumber = $"{course.ToUpper()}-2026-{serial.PadLeft(3, '0')}";

StringBuilder card = new StringBuilder();
string border = new string('=', 40);
card.AppendLine(border);
card.AppendLine("REGISTRATION CARD".PadLeft(28));
card.AppendLine(border);
card.AppendLine($"{"Roll number",-12}: {rollNumber}");
card.AppendLine($"{"Name",-12}: {ToTitleCase(name)}");
card.AppendLine($"{"Initials",-12}: {Initials(name)}");
card.AppendLine($"{"Mobile",-12}: {Mask(mobile)}");
card.AppendLine($"{"PIN code",-12}: {pin}");
card.AppendLine($"{"Email",-12}: {email.ToLower()}");
card.Append(border);

Console.WriteLine();
Console.WriteLine(card);

// Keeps asking until the typed text passes the check.
string ReadValid(string prompt, string field, string hint)
{
    while (true)
    {
        Console.Write(prompt);
        string text = (Console.ReadLine() ?? "").Trim();
        if (IsValid(field, text))
        {
            return text;
        }
        Console.WriteLine($"  Invalid. {hint}");
    }
}

// Picks the right check for each field.
bool IsValid(string field, string text)
{
    switch (field)
    {
        case "name": return IsValidName(text);
        case "mobile": return IsValidMobile(text);
        case "pin": return IsValidPin(text);
        case "email": return IsValidEmail(text);
        case "course": return IsValidCourse(text);
        case "serial": return IsValidSerial(text);
        default: return false;
    }
}

bool IsValidName(string text)
{
    if (text.Length < 2)
    {
        return false;
    }
    foreach (char ch in text)
    {
        if (!char.IsLetter(ch) && ch != ' ')
        {
            return false;
        }
    }
    return true;
}

bool IsValidMobile(string text)
{
    return text.Length == 10 && AllDigits(text) && text[0] >= '6' && text[0] <= '9';
}

bool IsValidPin(string text)
{
    return text.Length == 6 && AllDigits(text) && text[0] != '0';
}

// One '@', something before it, and a '.' somewhere after it, no spaces.
bool IsValidEmail(string text)
{
    int at = text.IndexOf('@');
    if (at <= 0 || at != text.LastIndexOf('@') || text.Contains(' '))
    {
        return false;
    }
    int dot = text.LastIndexOf('.');
    return dot > at + 1 && dot < text.Length - 1;
}

bool IsValidCourse(string text)
{
    return text.Equals("BCA", StringComparison.OrdinalIgnoreCase)
        || text.Equals("BSC", StringComparison.OrdinalIgnoreCase)
        || text.Equals("BTECH", StringComparison.OrdinalIgnoreCase);
}

bool IsValidSerial(string text)
{
    return text.Length >= 1 && text.Length <= 3 && AllDigits(text) && int.Parse(text) >= 1;
}

// Only the digits 0 to 9 (char.IsDigit also accepts digits of other scripts).
bool AllDigits(string text)
{
    foreach (char ch in text)
    {
        if (ch < '0' || ch > '9')
        {
            return false;
        }
    }
    return true;
}

// "aMAN   kumar singh" -> "Aman Kumar Singh"
string ToTitleCase(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < words.Length; i++)
    {
        string w = words[i].ToLower();
        words[i] = char.ToUpper(w[0]) + w.Substring(1);
    }
    return string.Join(" ", words);
}

// "aman kumar singh" -> "A. K. S."
string Initials(string text)
{
    StringBuilder result = new StringBuilder();
    foreach (string w in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        result.Append(char.ToUpper(w[0])).Append(". ");
    }
    return result.ToString().TrimEnd();
}

string Mask(string number)
{
    return number.Substring(0, 2) + new string('*', number.Length - 4) + number.Substring(number.Length - 2);
}
