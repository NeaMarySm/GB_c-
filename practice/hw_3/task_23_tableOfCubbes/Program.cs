/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int N = ReadNumber("Enter your number");
int count = 1;
if (!IsNegativeNum(N))
{
    while (count <= N)
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count++;
    }
} else {
    while (count >= N)
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count--;
    }
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsNegativeNum(int num)
{
    if (num < 0) return true;
    else return false;
}