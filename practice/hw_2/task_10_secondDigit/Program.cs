
/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/

int number = ReadNumber("Enter number from 100 to 999");

int secondDigit = number / 10 % 10;

Console.WriteLine($"Second digit of number {number} is {secondDigit}");


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

