Console.WriteLine($"Add(2, 3)        = {MathHelper.Add(2, 3)}");
Console.WriteLine($"Add(2, 3, 4)     = {MathHelper.Add(2, 3, 4)}");
Console.WriteLine($"Add(2.5, 3.5)    = {MathHelper.Add(2.5, 3.5)}");

Console.WriteLine($"Area(5)          = {MathHelper.Area(5)}");
Console.WriteLine($"Area(5, 3)       = {MathHelper.Area(5, 3)}");
Console.WriteLine($"Area(2.5, 4.0)   = {MathHelper.Area(2.5, 4.0)}");

static class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int Area(int side)
    {
        return side * side;
    }

    public static int Area(int length, int breadth)
    {
        return length * breadth;
    }

    public static double Area(double length, double breadth)
    {
        return length * breadth;
    }
}
