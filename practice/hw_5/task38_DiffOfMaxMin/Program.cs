// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным значениями элементов массива.

// [3 7 22 2 78] -> 76

int length = ReadNumber("Enter array length");
double[] randomArray = GenerateArrayOfdoubles(length);
PrintArray(randomArray);

double min = FindMin(randomArray);
double max = FindMax(randomArray);

// double min = FindExtrem(randomArray, false);
// double max = FindExtrem(randomArray, true);

// FindMaxMin(randomArray, out double max, out double min);

Console.WriteLine($"Max: {max} \nMin: {min} \nDifference: {max - min}");

double[] GenerateArrayOfdoubles(int length)
{
	double[] array = new double[length];
	for (int i = 0; i < length; i++)
	{
		double rndDouble = new Random().NextDouble();
		int rndInt = new Random().Next(-99, 100);
		array[i] = Math.Round(rndDouble * rndInt, 2);
	}
	return array;
}

// 1st option

double FindMax(double[] array)
{
	int maxIndex = 0;
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] > array[maxIndex])
		{
			maxIndex = i;
		}
	}
	return array[maxIndex];
}

double FindMin(double[] array)
{
	int minIndex = 0;
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] < array[minIndex])
		{
			minIndex = i;
		}
	}
	return array[minIndex];
}

// 2nd option

double FindExtrem(double[] array, bool findingMax)
{
	int minIndex = 0;
	int maxIndex = 0;
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] < array[minIndex])
		{
			minIndex = i;
		}
		else if (array[i] > array[maxIndex])
		{
			maxIndex = i;
		}
	}
	if (findingMax)
	{
		return array[maxIndex];
	}
	return array[minIndex];
}

// 3rd option
void FindMaxMin(double[] array, out double max, out double min)
{
	int minIndex = 0;
	int maxIndex = 0;
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] < array[minIndex])
		{
			minIndex = i;
		}
		else if (array[i] > array[maxIndex])
		{
			maxIndex = i;
		}
	}
	max = array[maxIndex];
	min = array[minIndex];
}

void PrintArray(double[] arr)
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
