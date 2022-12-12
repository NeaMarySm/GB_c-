// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] numbers = new int[5, 4];
FillTwoDimensionalArray(numbers, 0, 20);
PrintTwoDimensionalArray(numbers);

SortRows(numbers, false);
Console.WriteLine("Sorted array:");
PrintTwoDimensionalArray(numbers);

void SortRows(int[,] array, bool increase = true)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		int[] row = GetRow(array, i);
		BubbleSort(row, increase);
		SetRow(array, row, i);
	}
}
int[] GetRow(int[,] array, int rowIndex)
{
	int[] row = new int[array.GetLength(1)];
	for (int i = 0; i < array.GetLength(1); i++)
	{
		row[i] = array[rowIndex, i];
	}
	return row;
}
void SetRow(int[,] array, int[] row, int rowIndex)
{
	for (int i = 0; i < array.GetLength(1); i++)
	{
		array[rowIndex, i] = row[i];
	}
}
void BubbleSort(int[] array, bool increase = true)
{
	for (int i = 0; i < array.Length; i++)
	{
		for (int j = 0; j < array.Length - 1 - i; j++)
		{
			if (increase)
			{
				if (array[j] > array[j + 1])
				{
					Swap(ref array[j], ref array[j + 1]);
				}
			}
			else
			{
				if (array[j] < array[j + 1])
				{
					Swap(ref array[j], ref array[j + 1]);
				}
			}
		}
	}
}
void Swap(ref int first, ref int second)
{
	int temp = first;
	first = second;
	second = temp;
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

