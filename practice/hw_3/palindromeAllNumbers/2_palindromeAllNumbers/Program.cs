int number = ReadNumber("Enter your number");
IsPalindrome(number);

void IsPalindrome(int number)
{
    int initialNumber = number;
    int digits = CountDigits(number);
    while (digits > 1)
    {
        int divider = Convert.ToInt32(Math.Pow(10, (digits - 1)));
        int first = number / divider;
        int last = number % 10;
        if (first == last)
        {
            number = number % divider / 10;
            digits -= 2;
        }
        else
        {
            Console.WriteLine($"{initialNumber} is not a palindrome");
            digits = 0;
            return;
        }
    }
    Console.WriteLine($"{initialNumber} is a palindrome");
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
