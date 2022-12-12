/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrixOne = { { 2, 4 }, { 3, 2 } };
int[,] matrixTwo = { { 3, 4 }, { 3, 3 } };
// int[,] matrixOne = { { 1, 2, 2 }, { 3, 1, 1 } };
// int[,] matrixTwo = { { 4, 2 }, { 3, 1 }, { 1, 5 } };
// int[,] matrixOne = new int[3, 4];
// int[,] matrixTwo = new int[4, 3];
// FillTwoDimensionalArray(matrixOne, 0, 9);
// FillTwoDimensionalArray(matrixTwo, 0, 9);

PrintTwoDimensionalArray(matrixOne);
Console.WriteLine(" X");
PrintTwoDimensionalArray(matrixTwo);

int[,] resultMatrix = MultiplyMatrixes(matrixOne, matrixTwo);
Console.WriteLine("\n =\n");
PrintTwoDimensionalArray(resultMatrix);

int[,] MultiplyMatrixes(int[,] first, int[,] second)
{
	int rows = first.GetLength(0);
	int cols = first.GetLength(1);
	int[,] result = new int[rows, rows];
	int maxSize = rows > cols ? rows : cols;
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < rows; j++)
		{
			int count = 0;
			result[i, j] = 0;
			while (count < maxSize)
			{
				result[i, j] += first[i, count] * second[count, j];
				count++;
			}
		}
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