Console.WriteLine("Sisesta hinne:");
char Grade = char.Parse(Console.ReadLine());

if (Grade == 'A')
{
    Console.WriteLine("Suurepärane!");
}
else if (Grade == 'B')
{
    Console.WriteLine("Väga hea!");
}
else if (Grade == 'C')
{
    Console.WriteLine("Hea!");
}
else if (Grade == 'D')
{
    Console.WriteLine("Rahuldav");
}
else if (Grade == 'E')
{
    Console.WriteLine("Kasin");
}
else if (Grade == 'F')
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine("vale väärtus");
}
