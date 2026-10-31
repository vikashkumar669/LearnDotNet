// Program 4.10: GST Bill Calculator (mini project)

const string ShopName = "Sharma General Store";

Console.Write("Item name        : ");
string item = Console.ReadLine() ?? "";

Console.Write("Price per unit   : ");
decimal price = decimal.Parse(Console.ReadLine() ?? "");

Console.Write("Quantity         : ");
int quantity = int.Parse(Console.ReadLine() ?? "");

Console.Write("GST rate (%)     : ");
decimal gstRate = decimal.Parse(Console.ReadLine() ?? "");

decimal subtotal = price * quantity;
decimal gstAmount = subtotal * gstRate / 100;
decimal cgst = gstAmount / 2;
decimal sgst = gstAmount / 2;
decimal total = subtotal + gstAmount;

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine($"   {ShopName}");
Console.WriteLine("==================================");
Console.WriteLine($"Item       : {item}");
Console.WriteLine($"Rate x Qty : Rs. {price:F2} x {quantity}");
Console.WriteLine($"Subtotal   : Rs. {subtotal:F2}");
Console.WriteLine($"CGST       : Rs. {cgst:F2} ({gstRate / 2}%)");
Console.WriteLine($"SGST       : Rs. {sgst:F2} ({gstRate / 2}%)");
Console.WriteLine("----------------------------------");
Console.WriteLine($"Total      : Rs. {total:F2}");
Console.WriteLine("==================================");
