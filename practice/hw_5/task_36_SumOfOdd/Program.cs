// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int length = ReadNumber("Enter array length");
int[] randomArray = GenerateRandomArray(length);
PrintArray(randomArray);
int sum = SumOfElemsOnOddPosition(randomArray);
Console.WriteLine($"Sum of elements on odd positions is {sum}");

int SumOfElemsOnOddPosition(int[] array)
{
	int sum = 0;
	for (int i = 1; i < length; i += 2)
	{
		sum += array[i];
	}
	return sum;
}

int[] GenerateRandomArray(int arrayLength)
{
	int[] array = new int[arrayLength];
	for (int i = 0; i < arrayLength; i++)
	{
		array[i] = new Random().Next(-99, 100);
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
