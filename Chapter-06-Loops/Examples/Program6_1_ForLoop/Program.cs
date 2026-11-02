// Program 6.1: The for loop

// 1. Repeat a message 5 times
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Jai Hind {i}");
}

// 2. Add the numbers 1 to 10
int sum = 0;
for (int number = 1; number <= 10; number++)
{
    sum += number;
}
Console.WriteLine($"Sum of 1 to 10 = {sum}");

// 3. Count down
for (int count = 5; count >= 1; count--)
{
    Console.Write(count + " ");
}
Console.WriteLine("Lift off!");

// 4. Step by 2
for (int even = 2; even <= 10; even += 2)
{
    Console.Write(even + " ");
}
Console.WriteLine();
