Console.WriteLine($"Cube of 4          = {Cube(4)}");
Console.WriteLine($"Is 2028 a leap year? {IsLeapYear(2028)}");
Console.WriteLine($"Is 2100 a leap year? {IsLeapYear(2100)}");
Console.WriteLine($"Days in Feb 2028   = {DaysInFebruary(2028)}");
Console.WriteLine($"Days in Feb 2100   = {DaysInFebruary(2100)}");

int Cube(int n) => n * n * n;

bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

int DaysInFebruary(int year) => IsLeapYear(year) ? 29 : 28;
