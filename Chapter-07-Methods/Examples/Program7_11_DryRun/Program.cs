int result = Double(Add(2, 3)) + Add(1, 1);
Console.WriteLine($"result = {result}");

int Add(int a, int b)
{
    int sum = a + b;
    Console.WriteLine($"Add({a}, {b}) returns {sum}");
    return sum;
}

int Double(int n)
{
    int twice = n * 2;
    Console.WriteLine($"Double({n}) returns {twice}");
    return twice;
}
