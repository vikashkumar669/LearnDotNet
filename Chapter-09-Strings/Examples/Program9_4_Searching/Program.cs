string email = "priya.verma@gmail.com";

Console.WriteLine($"Email            : {email}");
Console.WriteLine($"Contains '@'     : {email.Contains('@')}");
Console.WriteLine($"Ends with '.com' : {email.EndsWith(".com")}");
Console.WriteLine($"Position of '@'  : {email.IndexOf('@')}");
Console.WriteLine($"Position of '.'  : {email.IndexOf('.')} (first), {email.LastIndexOf('.')} (last)");
Console.WriteLine($"Position of 'x'  : {email.IndexOf('x')}");

string[] vehicles = { "KA01AB1234", "TN09CD4321", "KA05MN7777", "MH12XY0001" };

Console.WriteLine();
Console.WriteLine("Vehicles registered in Karnataka:");
foreach (string number in vehicles)
{
    if (number.StartsWith("KA"))
    {
        Console.WriteLine($"  {number}");
    }
}

string message = "Exam on Monday. Hall opens at 9 am.";
Console.WriteLine();
Console.WriteLine($"Contains \"hall\"      : {message.Contains("hall")}");
Console.WriteLine($"Contains \"Hall\"      : {message.Contains("Hall")}");
Console.WriteLine($"\"Monday\" starts at   : {message.IndexOf("Monday")}");
