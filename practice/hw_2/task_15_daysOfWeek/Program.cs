/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет

*/
int day = ReadNumber("Enter day of week number");
IsWeekend(day);


void IsWeekend(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Yes");
    }
    else if (dayNumber > 7 || dayNumber < 1)
    {
        Console.WriteLine("No such day");
    }
    else
    {
        Console.WriteLine("No");
    }
}


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}