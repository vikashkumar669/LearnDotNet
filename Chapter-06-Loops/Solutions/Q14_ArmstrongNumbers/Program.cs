// Practice question 14: Armstrong numbers from 1 to 999 (one possible answer)

Console.WriteLine("Armstrong numbers from 1 to 999:");

for (int number = 1; number <= 999; number++)
{
    int rest = number;
    int cubeSum = 0;

    while (rest > 0)
    {
        int digit = rest % 10;
        cubeSum += digit * digit * digit;
        rest /= 10;
    }

    if (cubeSum == number)
    {
        Console.Write(number + " ");
    }
}
Console.WriteLine();
