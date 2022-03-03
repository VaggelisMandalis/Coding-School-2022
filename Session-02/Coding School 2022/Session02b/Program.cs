// 1)
Console.WriteLine("Hello Vaggelis");

// 2)
int a = 5;
int b = 6;
int sum = a + b;
double div = (double)a / b;
Console.WriteLine("The sum is :" +sum);
Console.WriteLine("The devision is :" + div);

// 3)

Console.WriteLine(-1 + 5 * 6);
Console.WriteLine(38 + (5 % 7));
double r = 14 + ((-3 * 6) / (double)7);
Console.WriteLine(r);
double d = 2 + (13 / (double)6) * 6 + Math.Sqrt(7);
Console.WriteLine(d);
double e = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);
Console.WriteLine(e);

// 4)

int age = 35;
string gender = "Female";
Console.WriteLine("You are " + gender + " and you look younger than " + age + ".");

//5)

int secs = 25152;
Console.WriteLine("There are " + (secs / (float)60) + " minutes, " + (secs / (float)3600) + "hours, " + (secs / (float)86400) + " days and " + (secs / (float)31556926) + " years.");

//6)

int seconds = 25152;
TimeSpan Interval = TimeSpan.FromSeconds(seconds);
Console.WriteLine("There are " + Interval.TotalMinutes + " minutes, " + Interval.TotalHours + " hours, "+ Interval.TotalDays + " days and "+ Interval.TotalDays/(float)365+" years.");
//7)
int tempCel = 45;
double tempKel = tempCel + 273;
double TempFahr = tempCel * (18 / 10) + 32;
Console.WriteLine("The temp in Celsius is : " + tempCel);
Console.WriteLine("The temp in Kelvin is : " + tempKel);
Console.WriteLine("The temp in Fahreneit is : " + tempCel);