
int WeekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0 - 6

switch (WeekDay) //Vääartus, mida kontrollitakse
{
    case 0:  //Case 0: = if (WeekDay
        Console.WriteLine("It's Sunday!");
        break;
    case 1: Console.WriteLine("It's Monday!");
        break;
    case 2: Console.WriteLine("It's Tuesday!");
        break;
    case 3: Console.WriteLine("It's Wednesday!");
        break;
    case 4: Console.WriteLine("It's Thursday!");
        break;
    case 5: Console.WriteLine("It's Friday!");
        break;
    case 6: Console.WriteLine("It's Saturday!");
        break;
    default:
        Console.WriteLine("Oops. Your calender must be broken.");
        break;
}

Console.WriteLine("Have a nice day");