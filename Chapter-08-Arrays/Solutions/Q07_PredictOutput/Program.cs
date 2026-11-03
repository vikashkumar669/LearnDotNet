int[] p = { 1, 2, 3 };
int[] q = p;
q[0] = 100;
Console.WriteLine(p[0]);
Change(p);
Console.WriteLine(string.Join(",", p));

void Change(int[] arr)
{
    arr[2] = arr[0] + arr[1];
}
