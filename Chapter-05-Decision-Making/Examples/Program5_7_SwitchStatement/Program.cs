// Program 5.7: The switch statement (month to season)

Console.Write("Enter month number (1-12): ");
int month = int.Parse(Console.ReadLine() ?? "");

string season;

switch (month)
{
    case 3:
    case 4:
    case 5:
        season = "Summer";
        break;
    case 6:
    case 7:
    case 8:
    case 9:
        season = "Monsoon";
        break;
    case 10:
    case 11:
        season = "Post-monsoon";
        break;
    case 12:
    case 1:
    case 2:
        season = "Winter";
        break;
    default:
        season = "Invalid month";
        break;
}

Console.WriteLine($"Season: {season}");
