// Practice question 7: predict the output (order of conditions)

int marks = 85;

if (marks >= 40)
{
    Console.WriteLine("Pass");
}
else if (marks >= 75)
{
    Console.WriteLine("Distinction");
}
else
{
    Console.WriteLine("Fail");
}

string kind = marks % 2 == 0 ? "even" : "odd";
Console.WriteLine(kind);
