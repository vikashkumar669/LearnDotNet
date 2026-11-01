// Program 5.3: The conditional operator ?:

int marks = 72;
int attendance = 68;

string result = marks >= 40 ? "Pass" : "Fail";
string hallTicket = attendance >= 75 ? "Issued" : "Withheld (attendance below 75%)";

Console.WriteLine($"Marks      : {marks} -> {result}");
Console.WriteLine($"Attendance : {attendance}% -> Hall ticket {hallTicket}");

int a = 34;
int b = 81;
int larger = a > b ? a : b;
Console.WriteLine($"Larger of {a} and {b} is {larger}");
