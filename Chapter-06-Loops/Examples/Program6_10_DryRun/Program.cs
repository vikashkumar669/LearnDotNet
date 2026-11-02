// Program 6.10: Dry run

int total = 0;
for (int i = 1; i <= 4; i++)
{
    if (i == 3)
    {
        continue;
    }
    total += i * 2;
    Console.WriteLine($"i = {i}, total = {total}");
}
Console.WriteLine($"Final total = {total}");
