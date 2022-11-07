/*
Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.
*/

int[] array = { 1, 8, 14, 12, 9, 0, 13, 88, 11, 5 };

PrintArray(array);
Console.WriteLine("Shuffled array:");
ArrayShuffle(ref array);
PrintArray(array);

void PrintArray(int[] arr)
{
	Console.WriteLine();
	foreach (int item in arr)
	{
		Console.Write(item + " ");
	}
	Console.WriteLine();
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
