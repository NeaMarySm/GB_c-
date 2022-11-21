/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. 
Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
*/

int[,] array = new int[4, 6];
FillTwoDimensionalArray(ref array);
PrintTwoDimensionalArray(array);
int[] indexes = new int[2];
GetInputData(ref indexes);
string value = FindValue(array, indexes);
Console.WriteLine(value);

void GetInputData(ref int[] array)
{
	Console.WriteLine("Enter position of the element in 2d array without space (indexes from 0 to 9): ");
	string input = Console.ReadLine();
	if (input.Length == 2)
	{
		array[0] = Convert.ToInt32(input[0].ToString());
		array[1] = Convert.ToInt32(input[1].ToString());
	}
	else GetInputData(ref array);
}
string FindValue(int[,] array, int[] position)
{
	if (position[0] >= array.GetLength(0) || position[1] >= array.GetLength(1))
		return "Such element doesn't exist in the array";
	return array[position[0], position[1]].ToString();
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
void FillTwoDimensionalArray(ref int[,] array, int min = -9, int max = 9)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(min, max + 1);
		}
	}
}