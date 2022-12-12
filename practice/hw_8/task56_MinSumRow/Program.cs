/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] numbers = new int[5, 6];
FillTwoDimensionalArray(numbers);
PrintTwoDimensionalArray(numbers);
int[] rows = CountSumsOfRows(numbers);
PrintArray(rows);
int minSumIndex = FindMinIndex(rows);
Console.WriteLine($"Row with the smallest sum of elements: {minSumIndex + 1}");

int[] CountSumsOfRows(int[,] array)
{
	int[] sums = new int[array.GetLength(0)];
	int sum = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			sum += array[i, j];
		}
		sums[i] = sum;
		sum = 0;
	}
	return sums;
}
int FindMinIndex(int[] array)
{
	int minIndex = 0;
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] < array[minIndex])
		{
			minIndex = i;
		}
	}
	return minIndex;
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
void FillTwoDimensionalArray(int[,] array, int min = 0, int max = 10)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(min, max + 1);
		}
	}
}

void PrintArray(int[] arr)
{
	Console.WriteLine();
	foreach (int item in arr)
	{
		Console.Write(item + " ");
	}
	Console.WriteLine();
}
