int[] ratings = { 5, 3, 4, 5, 2, 5, 4, 3, 5, 1, 4, 5 };
int[] count = new int[6];

foreach (int r in ratings)
{
    count[r]++;
}

Console.WriteLine($"Canteen survey: {ratings.Length} ratings");
for (int star = 5; star >= 1; star--)
{
    Console.WriteLine($"{star} star: {new string('*', count[star]),-6} ({count[star]})");
}
