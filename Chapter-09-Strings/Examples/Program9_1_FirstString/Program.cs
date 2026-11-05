string college = "National Institute of Technology";
string city = "Warangal";
string fullName = college + ", " + city;

Console.WriteLine(fullName);
Console.WriteLine($"Welcome to {city}!");

// Escape sequences
Console.WriteLine("Name:\tRavi Kumar");
Console.WriteLine("Line one\nLine two");
Console.WriteLine("He said \"Namaste\" to everyone.");
Console.WriteLine("Folder: C:\\Students\\BCA");

// Verbatim string: backslash is an ordinary character
Console.WriteLine(@"Folder: C:\Students\BCA");

// Empty string and joining a number
string empty = "";
int year = 2026;
string batch = "Batch " + year;
Console.WriteLine($"[{empty}] has length {empty.Length}");
Console.WriteLine(batch);

// Strings never change: a new string is made instead
string state = "kerala";
string upper = state.ToUpper();
Console.WriteLine($"state = {state}, upper = {upper}");
