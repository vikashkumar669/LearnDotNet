int[] a = { 10, 20, 30, 40 };
Console.WriteLine(a[1] + a[a.Length - 1]);
Console.WriteLine(a.Length);
a[2] = a[0] + 5;
foreach (int x in a)
{
    Console.Write(x + " ");
}
Console.WriteLine();
