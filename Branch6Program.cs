using System;

var time = 2;
var day = 4;
var month = 3;
int year = 1001;

if (time < 12 && time > 0)
{
    Console.WriteLine("Good Morning Sunshine!");
}

else if (time >= 13 && time < 19)
{
    Console.WriteLine("Good Afternoon! Work hard!");
}

else if (time >= 20 && time < 24)
{
    Console.WriteLine("Good Evening. Get some rest!");
}

else {
    Console.WriteLine("Please enter a real time.");
}

if (day > 0 && day <= 31)
{
    if (month > 0 && month <= 12)
    {
        if (year > 1500 && year < 3000)
        {
                Console.WriteLine(year + "/" + month + "/" + day);
            }
            else if (year < 1500 || year > 3000)
            {
                Console.WriteLine("Please enter a valid date.");
            }
            else
            {
                Console.Write("Please enter a valid date.");
            }
        }
    }

//// BONUS 

Console.WriteLine("Please write the day:");
string day1 = Console.ReadLine();

Console.WriteLine("Please write the month:");
string month1 = Console.ReadLine();

Console.WriteLine("Please write the year:");
string year1 = Console.ReadLine();

Console.WriteLine("Please select the date formatting. 1 - YYYY/MM/DD, 2- YYYY.MM.DD");
var answer = Console.ReadLine();

/*
if (answer = "1")
{ Console.WriteLine(year1 + "/" + month1 + "/" + day1);
}

if (answer = "2")
{
    Console.WriteLine(day1 + "/" + month1 + "/" + year1);
}
else
{
    Console.WriteLine("Please select from given options: 1 - YYYY/MM/DD, 2- YYYY.MM.DD");
}
*/
