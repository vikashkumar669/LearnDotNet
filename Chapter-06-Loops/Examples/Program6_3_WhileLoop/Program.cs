// Program 6.3: The while loop (digits of a number)

Console.Write("Enter a positive whole number: ");
int number = int.Parse(Console.ReadLine() ?? "");

int original = number;
int digitCount = 0;
int digitSum = 0;

while (number > 0)
{
    int lastDigit = number % 10;   // take the last digit
    digitSum += lastDigit;
    digitCount++;
    number /= 10;                  // remove the last digit
}

Console.WriteLine($"{original} has {digitCount} digits and the sum of its digits is {digitSum}.");
