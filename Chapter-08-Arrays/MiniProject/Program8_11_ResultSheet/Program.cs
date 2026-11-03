string[] subjects = { "Maths", "Science", "English" };

int count = ReadNumber("Number of students (1-10): ", 1, 10);
string[] names = new string[count];
int[,] marks = new int[count, subjects.Length];
int[] totals = new int[count];

for (int s = 0; s < count; s++)
{
    Console.WriteLine();
    names[s] = ReadName($"Name of student {s + 1}: ");
    for (int j = 0; j < subjects.Length; j++)
    {
        marks[s, j] = ReadNumber($"  {subjects[j]} marks (0-100): ", 0, 100);
        totals[s] += marks[s, j];
    }
}

PrintResultSheet(names, subjects, marks, totals);
PrintSubjectAverages(subjects, marks);

int topper = IndexOfMax(totals);
Console.WriteLine($"Class topper: {names[topper]} with {totals[topper]} marks");

int ReadNumber(string prompt, int min, int max)
{
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
        {
            return value;
        }
        Console.WriteLine($"Please type a whole number from {min} to {max}.");
    }
}

string ReadName(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string name = (Console.ReadLine() ?? "").Trim();
        if (name.Length > 0)
        {
            return name;
        }
        Console.WriteLine("The name cannot be empty.");
    }
}

void PrintResultSheet(string[] names, string[] subjects, int[,] marks, int[] totals)
{
    Console.WriteLine();
    Console.WriteLine("=============== Class Result Sheet ===============");
    Console.Write($"{"Name",-8}");
    foreach (string subject in subjects)
    {
        Console.Write($"{subject,8}");
    }
    Console.WriteLine($"{"Total",7}{"%",8}{"Grade",7}  Result");

    for (int s = 0; s < names.Length; s++)
    {
        Console.Write($"{names[s],-8}");
        for (int j = 0; j < subjects.Length; j++)
        {
            Console.Write($"{marks[s, j],8}");
        }
        double percentage = totals[s] * 100.0 / (subjects.Length * 100);
        string result = PassedAll(marks, s) ? "Pass" : "Fail";
        Console.WriteLine($"{totals[s],7}{percentage,8:F2}{GetGrade(percentage),7}  {result}");
    }
}

void PrintSubjectAverages(string[] subjects, int[,] marks)
{
    Console.Write($"{"Average",-8}");
    for (int j = 0; j < subjects.Length; j++)
    {
        int sum = 0;
        for (int s = 0; s < marks.GetLength(0); s++)
        {
            sum += marks[s, j];
        }
        Console.Write($"{(double)sum / marks.GetLength(0),8:F2}");
    }
    Console.WriteLine();
}

bool PassedAll(int[,] marks, int student)
{
    for (int j = 0; j < marks.GetLength(1); j++)
    {
        if (marks[student, j] < 35)
        {
            return false;
        }
    }
    return true;
}

int IndexOfMax(int[] values)
{
    int best = 0;
    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > values[best])
        {
            best = i;
        }
    }
    return best;
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
