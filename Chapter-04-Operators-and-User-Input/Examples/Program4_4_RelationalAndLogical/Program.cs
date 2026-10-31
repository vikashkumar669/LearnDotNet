// Program 4.4: Relational and logical operators

int marks = 72;
int attendance = 68;
char grade = 'B';

bool passed = marks >= 40;
bool goodAttendance = attendance >= 75;

Console.WriteLine($"Passed           : {passed}");
Console.WriteLine($"Good attendance  : {goodAttendance}");
Console.WriteLine($"Grade is A       : {grade == 'A'}");
Console.WriteLine($"Grade is not A   : {grade != 'A'}");
Console.WriteLine($"Can sit the exam : {passed && goodAttendance}");
Console.WriteLine($"Gets any credit  : {passed || goodAttendance}");
Console.WriteLine($"Failed           : {!passed}");
