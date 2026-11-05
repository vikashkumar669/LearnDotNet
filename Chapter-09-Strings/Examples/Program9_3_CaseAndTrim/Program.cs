Console.Write("Enter your name: ");
string typed = Console.ReadLine() ?? "";

string name = typed.Trim();

Console.WriteLine($"Typed   : [{typed}] ({typed.Length} characters)");
Console.WriteLine($"Trimmed : [{name}] ({name.Length} characters)");
Console.WriteLine($"Upper   : {name.ToUpper()}");
Console.WriteLine($"Lower   : {name.ToLower()}");
Console.WriteLine($"TrimStart: [{typed.TrimStart()}]");
Console.WriteLine($"TrimEnd  : [{typed.TrimEnd()}]");

Console.Write("Do you want a hostel room (yes/no)? ");
string answer = (Console.ReadLine() ?? "").Trim().ToLower();

if (answer == "yes")
{
    Console.WriteLine($"Hostel room booked for {name.ToUpper()}.");
}
else
{
    Console.WriteLine("No hostel room booked.");
}
