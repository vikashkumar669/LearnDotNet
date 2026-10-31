// Program 3.6: Student Profile Card (mini project)

string name = "Aarav Sharma";
int rollNo = 21;
char section = 'B';
string course = "BCA";
int semester = 2;
double cgpa = 8.456;
bool isHosteler = false;
decimal annualFee = 45000.50m;
const string College = "Government Engineering College";

Console.WriteLine("==================================");
Console.WriteLine("        STUDENT PROFILE CARD");
Console.WriteLine("==================================");
Console.WriteLine($"College    : {College}");
Console.WriteLine($"Name       : {name}");
Console.WriteLine($"Roll No    : {rollNo}");
Console.WriteLine($"Course     : {course}, Semester {semester}, Section {section}");
Console.WriteLine($"CGPA       : {cgpa:F2}");
Console.WriteLine($"Hosteler   : {isHosteler}");
Console.WriteLine($"Annual fee : Rs. {annualFee:F2}");
Console.WriteLine("==================================");
