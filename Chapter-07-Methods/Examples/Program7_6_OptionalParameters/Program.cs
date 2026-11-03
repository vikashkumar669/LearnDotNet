decimal fee1 = CalculateFee(50000m);
decimal fee2 = CalculateFee(50000m, 5m);
decimal fee3 = CalculateFee(50000m, hostel: true);
decimal fee4 = CalculateFee(hostel: true, amount: 50000m, gstPercent: 0m);

Console.WriteLine($"Fee 1 (default GST 18%)      : Rs. {fee1:F2}");
Console.WriteLine($"Fee 2 (GST 5%)               : Rs. {fee2:F2}");
Console.WriteLine($"Fee 3 (default GST, hostel)  : Rs. {fee3:F2}");
Console.WriteLine($"Fee 4 (no GST, hostel)       : Rs. {fee4:F2}");

decimal CalculateFee(decimal amount, decimal gstPercent = 18m, bool hostel = false)
{
    decimal total = amount + amount * gstPercent / 100;
    if (hostel)
    {
        total += 20000m;
    }
    return total;
}
