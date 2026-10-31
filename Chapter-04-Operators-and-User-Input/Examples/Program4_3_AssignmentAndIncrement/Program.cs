// Program 4.3: Compound assignment and increment

int balance = 500;
balance += 200;   // balance = balance + 200
Console.WriteLine($"After deposit    : {balance}");
balance -= 150;   // balance = balance - 150
Console.WriteLine($"After withdrawal : {balance}");
balance *= 2;
Console.WriteLine($"After *= 2       : {balance}");
balance /= 4;
Console.WriteLine($"After /= 4       : {balance}");
balance %= 100;
Console.WriteLine($"After %= 100     : {balance}");

int x = 5;
int y = x++;      // postfix: use 5, then x becomes 6
Console.WriteLine($"x = {x}, y = {y}");
int z = ++x;      // prefix: x becomes 7, then use 7
Console.WriteLine($"x = {x}, z = {z}");
