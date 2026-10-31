// Program 4.8: Casting and precedence

// Implicit conversion: small type to bigger type, no data lost
int marks = 85;
double percent = marks;
Console.WriteLine($"double from int : {percent}");

// Explicit conversion (cast): you accept that data may be lost
double price = 99.75;
int rupees = (int)price;
Console.WriteLine($"(int)99.75      : {rupees}");
Console.WriteLine($"Math.Round      : {Math.Round(price)}");

int big = 300;
byte small = (byte)big;
Console.WriteLine($"(byte)300       : {small}");

// Precedence: * / % before + -, left to right for equals
Console.WriteLine($"2 + 3 * 4       : {2 + 3 * 4}");
Console.WriteLine($"(2 + 3) * 4     : {(2 + 3) * 4}");
Console.WriteLine($"20 / 4 * 2      : {20 / 4 * 2}");
Console.WriteLine($"7 + 10 % 3      : {7 + 10 % 3}");
