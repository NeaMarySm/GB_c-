/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int A = ReadNumber("Enter first number");
int B = ReadNumber("Enter second number");

System.Console.WriteLine(Pow(A, B));

int Pow(int num, int pow)
{
	if (pow == 0)
		return 1;
	return num * Pow(num, pow - 1);
}

int ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}