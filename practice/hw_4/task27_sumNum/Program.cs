// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = ReadNumber("Enter your number: ");
Console.WriteLine(SumDigits(num));

int SumDigits(int number)
{
	if (number < 0)
	{
		number = -number;
	}
	int result = 0;
	while (number > 0)
	{
		result += number % 10;
		number /= 10;
	}
	return result;
}

int ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}