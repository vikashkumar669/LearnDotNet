// Example: letting C# find the type with var

var city = "Pune";    // string
var count = 5;        // int
var price = 99.5;     // double

Console.WriteLine($"{city.GetType().Name} {count.GetType().Name} {price.GetType().Name}");
