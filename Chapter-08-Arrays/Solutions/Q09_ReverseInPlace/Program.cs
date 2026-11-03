int[] numbers = new int[6];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Number {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine() ?? "");
}

int left = 0;
int right = numbers.Length - 1;
while (left < right)
{
    (numbers[left], numbers[right]) = (numbers[right], numbers[left]);
    left++;
    right--;
}

Console.WriteLine($"Reversed: {string.Join(" ", numbers)}");
