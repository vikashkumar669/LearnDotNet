string rollNumber = "BCA2026045";

string course = rollNumber.Substring(0, 3);
string year = rollNumber.Substring(3, 4);
string serial = rollNumber.Substring(7);

Console.WriteLine($"Roll number : {rollNumber}");
Console.WriteLine($"Course      : {course}");
Console.WriteLine($"Year        : {year}");
Console.WriteLine($"Serial      : {serial}");

string email = "rahul.k@yahoo.in";
int at = email.IndexOf('@');
string userName = email.Substring(0, at);
string domain = email.Substring(at + 1);
Console.WriteLine($"User name   : {userName}, domain: {domain}");

string mobile = "9876543210";
string masked = mobile.Substring(0, 2) + "******" + mobile.Substring(8);
Console.WriteLine($"Masked      : {masked}");

string notice = "Classes will be held on Saturday.";
Console.WriteLine(notice.Replace("Saturday", "Monday"));

string date = "05112026";
string withSlashes = date.Insert(4, "/").Insert(2, "/");
Console.WriteLine($"Date        : {withSlashes}");

string code = "PIN-560001";
Console.WriteLine($"Without PIN-: {code.Remove(0, 4)}");

int seat = 7;
Console.WriteLine($"Seat number : {seat.ToString().PadLeft(3, '0')}");
Console.WriteLine($"[{"Rice".PadRight(8)}][{"60".PadLeft(5)}]");
