/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

int rows = ReadInt("Enter number of rows: ");
int cols = ReadInt("Enter number of columns: ");
double[,] numbers = new double[rows, cols];
FillTwoDimensionalArray(ref numbers);
PrintTwoDimensionalArray(numbers);

void FillTwoDimensionalArray(ref double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			double rndDouble = new Random().NextDouble();
			int rndInt = new Random().Next(-99, 100);
			array[i, j] = Math.Round(rndDouble * rndInt, 2);
		}
	}
}
void PrintTwoDimensionalArray(double[,] array)
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