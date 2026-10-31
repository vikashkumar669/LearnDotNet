// Demo 1.A - Peek into the runtime

using System.Runtime.InteropServices;

Console.WriteLine(RuntimeInformation.FrameworkDescription);
Console.WriteLine(typeof(int).FullName);
Console.WriteLine(typeof(string).FullName);
Console.WriteLine(typeof(Console).Assembly.GetName().Name);
