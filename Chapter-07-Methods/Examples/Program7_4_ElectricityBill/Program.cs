int units = ReadUnits();
decimal bill = CalculateBill(units);
PrintBill(units, bill);

int ReadUnits()
{
    while (true)
    {
        Console.Write("Units consumed: ");
        string text = Console.ReadLine() ?? "";

        if (int.TryParse(text, out int units) && units >= 0)
        {
            return units;
        }
        Console.WriteLine("Please type a whole number, zero or more.");
    }
}

decimal CalculateBill(int units)
{
    if (units <= 100)
    {
        return units * 3.00m;
    }
    if (units <= 200)
    {
        return 100 * 3.00m + (units - 100) * 4.50m;
    }
    if (units <= 300)
    {
        return 100 * 3.00m + 100 * 4.50m + (units - 200) * 6.00m;
    }
    return 100 * 3.00m + 100 * 4.50m + 100 * 6.00m + (units - 300) * 7.50m;
}

void PrintBill(int units, decimal bill)
{
    Console.WriteLine("----- Electricity Bill -----");
    Console.WriteLine($"Units consumed : {units}");
    Console.WriteLine($"Bill amount    : Rs. {bill:F2}");
}
