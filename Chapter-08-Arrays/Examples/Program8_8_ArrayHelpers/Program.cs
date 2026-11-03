int[] scores = { 45, 92, 67, 81, 58, 73 };
string[] states = { "Kerala", "Assam", "Punjab", "Goa", "Bihar" };

int[] sorted = new int[scores.Length];
Array.Copy(scores, sorted, scores.Length);

Array.Sort(sorted);
Console.WriteLine($"Sorted, smallest first : {string.Join(", ", sorted)}");
Array.Reverse(sorted);
Console.WriteLine($"Sorted, largest first  : {string.Join(", ", sorted)}");
Console.WriteLine($"Original is unchanged  : {string.Join(", ", scores)}");

Array.Sort(states);
Console.WriteLine($"States A to Z          : {string.Join(", ", states)}");

Console.WriteLine($"Index of 81            : {Array.IndexOf(scores, 81)}");
Console.WriteLine($"Index of 100           : {Array.IndexOf(scores, 100)}");
Console.WriteLine($"Is Goa in the list?    : {Array.IndexOf(states, "Goa") >= 0}");
