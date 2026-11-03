int marks = 70;
Console.WriteLine($"Before AddBonusWrong : marks = {marks}");
AddBonusWrong(marks);
Console.WriteLine($"After AddBonusWrong  : marks = {marks}");

marks = AddBonus(marks);
Console.WriteLine($"After AddBonus       : marks = {marks}");

void AddBonusWrong(int marks)
{
    marks += 5;
    Console.WriteLine($"Inside AddBonusWrong : marks = {marks}");
}

int AddBonus(int marks)
{
    return marks + 5;
}
