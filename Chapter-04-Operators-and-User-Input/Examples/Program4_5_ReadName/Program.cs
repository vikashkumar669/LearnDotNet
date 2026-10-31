// Program 4.5: Reading text from the keyboard

Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? "";

Console.Write("Enter your city: ");
string city = Console.ReadLine() ?? "";

Console.WriteLine($"Namaste, {name} from {city}!");
