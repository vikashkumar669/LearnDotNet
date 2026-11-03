Console.WriteLine($"Convert(100)          = {Temperature.Convert(100.0)} F");
Console.WriteLine($"Convert(98.6, \"F\")    = {Temperature.Convert(98.6, "F"):F1} C");
Console.WriteLine($"Convert(37, \"C\")      = {Temperature.Convert(37.0, "C"):F1} F");

static class Temperature
{
    public static double Convert(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    public static double Convert(double value, string from)
    {
        if (from == "F")
        {
            return (value - 32) * 5 / 9;
        }
        return value * 9 / 5 + 32;
    }
}
