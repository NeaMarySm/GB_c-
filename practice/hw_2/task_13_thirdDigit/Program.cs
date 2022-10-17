/* 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int initialNumber = ReadNumber("Enter your number ");
int number = initialNumber;
bool cycle = true;
if (number / 100 == 0)
{
    Console.WriteLine("The number has less then 3 digits");
}
else
{
    while (cycle)
    {
        if (number / 1000 != 0)
        {
            number = number / 10;
        }
        else
        {
            Console.WriteLine($"Third digit of number {initialNumber} is {number % 10}");
            cycle = false;
        }
    }
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
