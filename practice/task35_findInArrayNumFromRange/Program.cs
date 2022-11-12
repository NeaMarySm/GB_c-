// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int length = 123;
int minOfArray = 0;
int maxOfArray = 500;
int minOfRange = 10;
int maxOfRange = 99;
int[] randomArray = GenerateRandomArray(length, minOfArray, maxOfArray);
int[] range = GenerateRange(minOfRange, maxOfRange);
PrintArray(randomArray);
int coinsedences = CountCoinsedenceInArray(randomArray, range);
Console.WriteLine(coinsedences);



int[] GenerateRange(int min, int max)
{
	int length = max - min + 1;
	int[] array = new int[length];
	for (int i = min, j = 0; j < length; i++, j++)
	{
		array[j] = i;
	}
	return array;
}

int CountCoinsedenceInArray(int[] array, int[] range)
{
	int result = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (FindInArray(range, array[i]))
		{
			result++;
		}

	}
	return result;

}
bool FindInArray(int[] array, int value)
{
	bool result = false;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == value)
		{
			result = true;
			break;
		}
	}
	return result;

}

int[] GenerateRandomArray(int arrayLength, int min, int max)
{
	int[] array = new int[arrayLength];
	for (int i = 0; i < arrayLength; i++)
	{
		array[i] = new Random().Next(min, max + 1);
	}
	return array;
}

void PrintArray(int[] arr)
{
	Console.WriteLine();
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write(arr[i] + " ");
	}
	Console.WriteLine();
}

