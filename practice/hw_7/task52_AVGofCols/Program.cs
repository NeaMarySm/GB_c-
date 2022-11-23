/*
Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/

int[,] numbers = new int[4, 3];
FillTwoDimensionalArray(ref numbers);
PrintTwoDimensionalArray(numbers);
double[] averages = AveragesForColumns(numbers);
PrintArrayOfDoubles(averages);

void PrintArrayOfDoubles(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(Math.Round(array[i], 2) + " ");
	}
}
double[] AveragesForColumns(int[,] array)
{
	int numberOfRows = array.GetLength(0);
	int numberOfCols = array.GetLength(1);
	double[] resultArray = new double[numberOfCols];
	for (int i = 0; i < numberOfRows; i++)
	{
		for (int j = 0; j < numberOfCols; j++)
		{
			resultArray[j] += Convert.ToDouble(array[i, j]) / numberOfRows;
		}
	}
	return resultArray;
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
void FillTwoDimensionalArray(ref int[,] array, int min = 0, int max = 9)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(min, max + 1);
		}
	}
}
