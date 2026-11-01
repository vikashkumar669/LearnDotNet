// Practice question 8: predict the output (switch)

char grade = 'B';

switch (grade)
{
    case 'A':
        Console.WriteLine("Excellent");
        break;
    case 'B':
    case 'C':
        Console.WriteLine("Good");
        break;
    default:
        Console.WriteLine("Keep trying");
        break;
}

int day = 9;
string type = day switch
{
    6 or 7 => "Weekend",
    >= 1 and <= 5 => "Weekday",
    _ => "Invalid"
};
Console.WriteLine(type);
