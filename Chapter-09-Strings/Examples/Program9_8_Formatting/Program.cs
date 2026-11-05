using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("en-IN");

string[] items = { "Notebook", "Gel pen", "Calculator", "Geometry box" };
int[] quantity = { 6, 10, 1, 2 };
decimal[] price = { 45.50m, 10m, 1250m, 89.99m };

Console.WriteLine("BHARAT STATIONERY, BENGALURU");
Console.WriteLine($"{"Item",-14}{"Qty",5}{"Price",12}{"Amount",12}");
Console.WriteLine(new string('-', 43));

decimal total = 0;
for (int i = 0; i < items.Length; i++)
{
    decimal amount = quantity[i] * price[i];
    total += amount;
    Console.WriteLine($"{items[i],-14}{quantity[i],5}{price[i],12:N2}{amount,12:N2}");
}

Console.WriteLine(new string('-', 43));
Console.WriteLine($"{"Total",-14}{total,29:N2}");
Console.WriteLine();

decimal fee = 125000m;
Console.WriteLine($"Fee (N2)        : {fee:N2}");
Console.WriteLine($"Fee (C)         : {fee:C}");
Console.WriteLine($"Fee (N0)        : {fee:N0}");
Console.WriteLine($"Fee (invariant) : {fee.ToString("N2", CultureInfo.InvariantCulture)}");

int rank = 7;
double percent = 0.8675;
Console.WriteLine($"Rank (D3)       : {rank:D3}");
Console.WriteLine($"Percent (P1)    : {percent:P1}");
Console.WriteLine($"Date            : {new DateTime(2026, 11, 5):dd-MM-yyyy}");
