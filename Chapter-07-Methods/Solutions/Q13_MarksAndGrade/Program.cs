int[] marks = new int[3];
string[] subjects = { "Maths", "Physics", "Chemistry" };

for (int i = 0; i < subjects.Length; i++)
{
    marks[i] = ReadMarks(subjects[i]);
}

int total = marks[0] + marks[1] + marks[2];
double percentage = total / 3.0;
Console.WriteLine($"Total      : {total} / 300");
Console.WriteLine($"Percentage : {percentage:F2}%");
Console.WriteLine($"Grade      : {GetGrade(percentage)}");

int ReadMarks(string subject)
{
    while (true)
    {
        Console.Write($"{subject} marks (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int value) && value >= 0 && value <= 100)
        {
            return value;
        }
        Console.WriteLine("Invalid marks. Try again.");
    }
}

string GetGrade(double percentage)
{
    return percentage switch
    {
        >= 90 => "A+",
        >= 75 => "A",
        >= 60 => "B",
        >= 40 => "C",
        _ => "Fail"
    };
}
