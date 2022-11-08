// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int length = ReadNumber("Enter array length");
int[] randomArray = GenerateRandomArray(length);
PrintArray(randomArray);

int[] GenerateRandomArray(int arrayLength)
{
	int[] array = new int[arrayLength];
	for (int i = 0; i < arrayLength; i++)
	{
		array[i] = new Random().Next(0, 100);
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