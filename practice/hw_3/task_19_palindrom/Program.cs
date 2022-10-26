/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int number = ReadNumber("Enter five digit number");
if (CountDigits(number) != 5)
{
    Console.WriteLine("It is not five digit number");
    return;
}
IsPalindrome5(number);


void IsPalindrome5(int fiveDigitNum)
{
    int firstDigit = fiveDigitNum / 10000;
    int secondDigit = fiveDigitNum / 1000 % 10;
    int penultDigit = fiveDigitNum % 100 / 10;
    int lastDigit = fiveDigitNum % 10;
    if (firstDigit == lastDigit)
    {
        if (secondDigit == penultDigit)
        {
            Console.WriteLine(number + "-> yes");
        }
        else Console.WriteLine(number + "-> no");
    }
    else Console.WriteLine(number + "-> no");
}


int CountDigits(int num)
{
    int count = 0;
    int tempNum = num;
    if (num < 0)
    {
        tempNum = -num;
    }
    else if (num == 0)
    {
        return 1;
    }
    while (tempNum > 0)
    {
        tempNum /= 10;
        count++;
    }
    return count;
}
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


