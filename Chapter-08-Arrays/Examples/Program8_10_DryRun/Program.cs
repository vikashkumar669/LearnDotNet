int[] a = { 3, 8, 2, 9, 4 };
int result = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 0)
    {
        result += a[i];
    }
    else
    {
        result -= a[i];
    }
}

Console.WriteLine($"result = {result}");
