int[] rollNumbers = { 101, 104, 107, 110, 113, 116 };
string[] names = { "Aarav", "Diya", "Kabir", "Meera", "Rohan", "Sneha" };

Console.Write("Enter a roll number to search: ");
int target = int.Parse(Console.ReadLine() ?? "");

int position = -1;
for (int i = 0; i < rollNumbers.Length; i++)
{
    if (rollNumbers[i] == target)
    {
        position = i;
        break;
    }
}

if (position >= 0)
{
    Console.WriteLine($"Found at index {position}: {names[position]}");
}
else
{
    Console.WriteLine($"Roll number {target} is not in the class list.");
}
