using System.Text.RegularExpressions;

string text = "298597635";

bool result=Regex.IsMatch(text,@"^[0-9]+$");
Console.WriteLine(result);

string text1="Hello123";
bool ans = Regex.IsMatch(text1, @"^[A-Z][A-Za-z0-9]*$");
Console.WriteLine(ans);

string checkUpperCase="CHITKARA UNIVERSITY";
bool check=Regex.IsMatch(checkUpperCase,@"^[A-Z\s]+$");
Console.WriteLine(check);

string alphaNumeric="Hello123";
bool checkAlpha=Regex.IsMatch(alphaNumeric,@"^[A-Za-z0-9]+$");
Console.WriteLine(checkAlpha);

string strongPassword="Windygod@123";
bool passwordCheck=Regex.IsMatch(strongPassword,
    @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$");
Console.WriteLine(passwordCheck);

string email = "yash123@gmail.com";
bool emailCheck = Regex.IsMatch(email,
    @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]+$");
Console.WriteLine(emailCheck);

string text5 = "Your bill amount is ₹2456.75 INR.";

string pattern = @"₹[0-9]{4}\.[0-9]{2}";

Match match = Regex.Match(text5, pattern);

Console.WriteLine(match.Value);