// Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] numbers = new int[4, 5, 4];
Fill3DArray(numbers);
Print3DArrayWithIndexes(numbers);

void Print3DArrayWithIndexes(int[,,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(2); k++)
			{

				Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}
void Fill3DArray(int[,,] array, int min = 10, int max = 99)
{
	if (array.Length > max)
	{
		Console.WriteLine($"Array length is more than {max} elements");
		return;
	}
	int[] randoms = GenerateShuffledRange(array.Length, min);
	int randomsIndex = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(2); k++)
			{
				array[i, j, k] = randoms[randomsIndex++];
			}
		}
	}
}
int[] GenerateShuffledRange(int amount, int min)
{
	int[] randoms = new int[amount];
	for (int i = 0; i < amount; i++)
	{
		randoms[i] = min++;
	}
	ArrayShuffle(ref randoms);
	return randoms;
}
void ArrayShuffle(ref int[] array)
{
	int length = array.Length;
	int[] newArray = new int[length];
	int max = length - 1;
	for (int i = 0; i < length; i++)
	{
		int index = new Random().Next(0, max + 1);
		newArray[i] = array[index];
		int temp = array[max];
		array[max] = array[index];
		array[index] = temp;
		max--;
	}
	array = newArray;
}