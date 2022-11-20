/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
*/
int[,] numbers = new int[4, 4];
FillTwoDimensionalArray(ref numbers);
PrintTwoDimensionalArray(numbers);
Console.WriteLine();
ReplaceElementsWithOddIndexes(ref numbers);
PrintTwoDimensionalArray(numbers);

void ReplaceElementsWithOddIndexes(ref int[,] array)
{
	for (int i = 1; i < array.GetLength(0); i += 2)
	{
		for (int j = 1; j < array.GetLength(1); j += 2)
		{
			array[i, j] *= array[i, j];
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