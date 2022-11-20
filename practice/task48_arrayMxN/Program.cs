/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int m = ReadInt("Enter number of rows");
int n = ReadInt("Enter number of columns");
int[,] userArray = new int[m, n];

FillArrayWithSumOfIndexes(ref userArray);
PrintTwoDimensionalArray(userArray);
void FillArrayWithSumOfIndexes(ref int[,] array)
{
	for (int m = 0; m < array.GetLength(0); m++)
	{
		for (int n = 0; n < array.GetLength(1); n++)
		{
			array[m, n] = m + n;
		}
	}
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
int ReadInt(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}