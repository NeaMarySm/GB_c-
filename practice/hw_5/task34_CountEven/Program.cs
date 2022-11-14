// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int length = ReadNumber("Enter array length");
int[] randomArray = GenerateRandomArray(length);
PrintArray(randomArray);
Console.WriteLine($"Number of even: {CountEvenNumbers(randomArray)}");

int CountEvenNumbers(int[] array)
{
	int result = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			result++;
		}
	}
	return result;
}
int[] GenerateRandomArray(int arrayLength)
{
	int[] array = new int[arrayLength];
	for (int i = 0; i < arrayLength; i++)
	{
		array[i] = new Random().Next(100, 1000);
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
