// Program 6.11: Number Guessing Game

Random random = new Random(2026);
int secret = random.Next(1, 101);   // a whole number from 1 to 100
const int MaxAttempts = 7;

int attempts = 0;
bool won = false;

Console.WriteLine("Number Guessing Game");
Console.WriteLine($"I am thinking of a number from 1 to 100. You have {MaxAttempts} attempts.");

while (attempts < MaxAttempts && !won)
{
    Console.Write($"Attempt {attempts + 1}: your guess? ");
    string text = Console.ReadLine() ?? "";

    if (!int.TryParse(text, out int guess) || guess < 1 || guess > 100)
    {
        Console.WriteLine("Please type a whole number from 1 to 100. This does not count as an attempt.");
        continue;
    }

    attempts++;

    if (guess == secret)
    {
        won = true;
    }
    else if (guess < secret)
    {
        Console.WriteLine("Too low.");
    }
    else
    {
        Console.WriteLine("Too high.");
    }
}

if (won)
{
    string rating = attempts switch
    {
        <= 3 => "Excellent!",
        <= 5 => "Good job!",
        _ => "You made it, just in time."
    };
    Console.WriteLine($"Correct! You found {secret} in {attempts} attempts. {rating}");
}
else
{
    Console.WriteLine($"Out of attempts. The number was {secret}.");
}
