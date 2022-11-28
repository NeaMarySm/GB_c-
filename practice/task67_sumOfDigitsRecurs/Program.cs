/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int number = ReadNumber("Enter number");

int Sum(int num)
{
	if (num == 0)
	{
		return 0;
	}
	else
	{
		num = Sum(num % 10);
	}
	return sum;

}

int ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}