/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int N = ReadNumber("Enter your number:");
PrintNaturalNumbers(N);

void PrintNaturalNumbers(int start)
{
	if (start < 1)
	{
		Console.WriteLine("Number should be positive");
		return;
	}
	else if (start == 1)
		Console.WriteLine(start);
	else
	{
		Console.Write(start + " ");
		PrintNaturalNumbers(start - 1);
	}
}

int ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}