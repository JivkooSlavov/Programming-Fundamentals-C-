﻿string[] days =new string[7]
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};
int number = int.Parse(Console.ReadLine());
if (number>1 && number<7)
{
    Console.WriteLine(days[number]);
}
else
{
    Console.WriteLine("Ivalid day.");
}