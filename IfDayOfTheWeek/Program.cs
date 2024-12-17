
int WeekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (WeekDay == 0)
{
    Console.WriteLine("It's Sunday!");
}
else if (WeekDay == 1)
{
    Console.WriteLine("It's Monday!");
}
else if (WeekDay == 2)
{
    Console.WriteLine("It's Tuesday!");
}
else if (WeekDay == 3)
{
    Console.WriteLine("It's Wednesday!");
}
else if (WeekDay == 4)
{
    Console.WriteLine("It's Thursday!");
}
else if (WeekDay == 5)
{
    Console.WriteLine("It's Friday!");
}
else if (WeekDay == 6)
{
    Console.WriteLine("It's Saturday!");
}
Console.WriteLine("Have a nice day!");