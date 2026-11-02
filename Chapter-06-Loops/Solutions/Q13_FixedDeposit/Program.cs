// Practice question 13: fixed deposit growth table (one possible answer)

decimal amount = 10000m;
const decimal Rate = 7m;   // 7% a year

Console.WriteLine("Year    Interest      Amount");
Console.WriteLine("----  ----------  ----------");

for (int year = 1; year <= 5; year++)
{
    decimal interest = amount * Rate / 100;
    amount += interest;
    Console.WriteLine($"{year,4}  {interest,10:F2}  {amount,10:F2}");
}
