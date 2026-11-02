// Program 6.6: break and continue

// break: stop the loop early
for (int number = 51; number <= 100; number++)
{
    if (number % 7 == 0)
    {
        Console.WriteLine($"First multiple of 7 after 50: {number}");
        break;
    }
}

// continue: skip this round and go to the next one
int oddSum = 0;
for (int number = 1; number <= 10; number++)
{
    if (number % 2 == 0)
    {
        continue;   // even numbers are skipped
    }
    oddSum += number;
}
Console.WriteLine($"Sum of odd numbers from 1 to 10 = {oddSum}");
