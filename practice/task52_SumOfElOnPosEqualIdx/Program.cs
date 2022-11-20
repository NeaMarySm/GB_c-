/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
*/

int[,] numbers = new int[5, 4];
FillTwoDimensionalArray(ref numbers);
PrintTwoDimensionalArray(numbers);
Console.WriteLine();
int sum = FindSumOnMainDiagonal(numbers);
int sumOptimized = FindSumOnMainDiagonalOptimized(numbers);
Console.WriteLine(sum);
Console.WriteLine(sumOptimized);

int FindSumOnMainDiagonal(int[,] array)
{
	int result = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (i == j)
			{
				result += array[i, j];
				break;
			}
		}
	}
	return result;
}
int FindSumOnMainDiagonalOptimized(int[,] array)
{
	int result = 0;
	int count = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
	for (int i = 0; i < count; i++)
	{
		result += array[i, i];
	}
	return result;
}


void PrintTwoDimensionalArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}
void FillTwoDimensionalArray(ref int[,] array, int min = 0, int max = 10)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(min, max + 1);
		}
	}
}
int ReadInt(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}
