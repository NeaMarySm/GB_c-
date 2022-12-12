/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int M = ReadNumber("Enter first number: ");
int N = ReadNumber("Enter second number: ");
int sum = FindSumOfRange(M, N);
Console.WriteLine(sum);

int FindSumOfRange(int start, int end)
{
	if (start > end)
	{
		int temp = start;
		start = end;
		end = temp;
	}
	if (start == end)
	{
		return end;
	}
	else return start + FindSumOfRange(start + 1, end);
}
int ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}