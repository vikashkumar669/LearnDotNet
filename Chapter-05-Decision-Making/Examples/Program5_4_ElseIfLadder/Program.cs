// Program 5.4: else-if ladder (electricity bill)
// Slab rates are example values, not a real tariff.

Console.Write("Units consumed: ");
int units = int.Parse(Console.ReadLine() ?? "");

decimal bill;

if (units <= 100)
{
    bill = units * 3.00m;
}
else if (units <= 200)
{
    bill = 100 * 3.00m + (units - 100) * 4.50m;
}
else if (units <= 300)
{
    bill = 100 * 3.00m + 100 * 4.50m + (units - 200) * 6.00m;
}
else
{
    bill = 100 * 3.00m + 100 * 4.50m + 100 * 6.00m + (units - 300) * 7.50m;
}

Console.WriteLine($"Bill amount   : Rs. {bill:F2}");
