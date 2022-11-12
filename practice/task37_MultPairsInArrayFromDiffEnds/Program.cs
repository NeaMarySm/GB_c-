// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int length = ReadNumber("Enter array length");
int[] randomArray = GenerateRandomArray(length);
PrintArray(randomArray);
PrintArray(MultOfPairsArray(randomArray));

int[] MultOfPairsArray(int[] array)
{
	int length = array.Length;
	int resultArrayLength = length % 2 == 0 ? length / 2 : length / 2 + 1;
	int[] resultArray = new int[resultArrayLength];
	for (int i = 0, j = length - 1; i < resultArrayLength; i++, j--)
	{
		if (i == j)
		{
			resultArray[i] = array[i];
			break;
		}
		resultArray[i] = array[i] * array[j];
	}
	return resultArray;
}

int[] GenerateRandomArray(int arrayLength)
{
	int[] array = new int[arrayLength];
	for (int i = 0; i < arrayLength; i++)
	{
		array[i] = new Random().Next(0, 10);
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

int ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}
