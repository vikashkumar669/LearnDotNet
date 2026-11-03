int number = 50;
int[] marks = { 50, 60, 70 };

AddFiveToNumber(number);
AddFiveToArray(marks);
Console.WriteLine($"number after the method  : {number}");
Console.WriteLine($"marks after the method   : {string.Join(", ", marks)}");

int[] sameArray = marks;
sameArray[0] = 0;
Console.WriteLine($"marks after sameArray[0] = 0 : {string.Join(", ", marks)}");

int[] realCopy = new int[marks.Length];
Array.Copy(marks, realCopy, marks.Length);
realCopy[1] = 0;
Console.WriteLine($"marks after realCopy[1] = 0  : {string.Join(", ", marks)}");
Console.WriteLine($"realCopy                     : {string.Join(", ", realCopy)}");

void AddFiveToNumber(int n)
{
    n += 5;
}

void AddFiveToArray(int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] += 5;
    }
}
