
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int num = ReadNumber("Enter your number: ");
int pow = ReadNumber("Enter pow: ");

while (pow < 0)
{
	pow = ReadNumber("Enter non-negative value: ");
}
Console.WriteLine(Pow(num, pow));

int Pow(int number, int pow)
{
	int result = 1;
	while (pow > 0)
	{
		result *= number;
		pow--;
	}
	return result;
}

int ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}