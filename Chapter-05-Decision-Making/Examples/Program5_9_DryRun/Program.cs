// Program 5.9: Dry run

int marks = 37;
int bonus = 0;
string remark;

if (marks >= 35 && marks < 40)
{
    bonus = 40 - marks;
}

marks += bonus;

if (marks >= 60)
{
    remark = "First division";
}
else if (marks >= 45)
{
    remark = "Second division";
}
else if (marks >= 40)
{
    remark = "Pass";
}
else
{
    remark = "Fail";
}

Console.WriteLine($"marks = {marks}, bonus = {bonus}, remark = {remark}");
