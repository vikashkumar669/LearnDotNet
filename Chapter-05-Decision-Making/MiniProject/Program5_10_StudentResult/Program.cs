// Program 5.10: Student Result Calculator

const int PassMark = 33;
const int MaxTotal = 500;

Console.Write("Student name : ");
string name = Console.ReadLine() ?? "";

Console.Write("English      : ");
bool ok1 = int.TryParse(Console.ReadLine(), out int english);
Console.Write("Hindi        : ");
bool ok2 = int.TryParse(Console.ReadLine(), out int hindi);
Console.Write("Maths        : ");
bool ok3 = int.TryParse(Console.ReadLine(), out int maths);
Console.Write("Science      : ");
bool ok4 = int.TryParse(Console.ReadLine(), out int science);
Console.Write("Computer     : ");
bool ok5 = int.TryParse(Console.ReadLine(), out int computer);

if (!(ok1 && ok2 && ok3 && ok4 && ok5))
{
    Console.WriteLine("Please enter whole numbers only.");
}
else if (english < 0 || english > 100 || hindi < 0 || hindi > 100
         || maths < 0 || maths > 100 || science < 0 || science > 100
         || computer < 0 || computer > 100)
{
    Console.WriteLine("Marks must be between 0 and 100.");
}
else
{
    int total = english + hindi + maths + science + computer;
    double percentage = total * 100.0 / MaxTotal;

    int failedSubjects = 0;
    failedSubjects += english < PassMark ? 1 : 0;
    failedSubjects += hindi < PassMark ? 1 : 0;
    failedSubjects += maths < PassMark ? 1 : 0;
    failedSubjects += science < PassMark ? 1 : 0;
    failedSubjects += computer < PassMark ? 1 : 0;

    string result = failedSubjects switch
    {
        0 => "PASS",
        1 or 2 => "SUPPLEMENTARY",
        _ => "FAIL"
    };

    string grade;
    if (result == "PASS")
    {
        grade = percentage switch
        {
            >= 90 => "A+",
            >= 75 => "A",
            >= 60 => "B",
            >= 45 => "C",
            _ => "D"
        };
    }
    else
    {
        grade = "-";
    }

    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("        REPORT CARD");
    Console.WriteLine("==================================");
    Console.WriteLine($"Name       : {name}");
    Console.WriteLine($"Total      : {total} / {MaxTotal}");
    Console.WriteLine($"Percentage : {percentage:F2}%");
    Console.WriteLine($"Failed in  : {failedSubjects} subject(s)");
    Console.WriteLine($"Result     : {result}");
    Console.WriteLine($"Grade      : {grade}");
    Console.WriteLine("==================================");
}
