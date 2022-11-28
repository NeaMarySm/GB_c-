/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

int M = ReadNumber("Enter first number");
int N = ReadNumber("Enter second number");
NaturalNumber(M, N);

void NaturalNumber(int startNum, int lastNum)
{
	if (startNum > lastNum)
	{
		int temp = startNum;
		startNum = lastNum;
		lastNum = temp;
	}
	if (lastNum == startNum)
	{
		Console.Write(startNum + " ");
	}
	else
	{
		NaturalNumber(startNum, lastNum - 1);
		Console.Write(lastNum + " ");
	}
}
int ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}