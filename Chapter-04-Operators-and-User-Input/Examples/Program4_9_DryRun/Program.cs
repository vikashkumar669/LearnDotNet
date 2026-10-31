// Program 4.9: Dry run

int a = 10;
int b = 3;
a += b * 2;
b = a % 5;
int c = a / b++;
bool ok = c > 15 && b == 2;
Console.WriteLine($"a = {a}, b = {b}, c = {c}, ok = {ok}");
