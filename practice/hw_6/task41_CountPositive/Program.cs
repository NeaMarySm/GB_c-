// Задача 41: Пользователь вводит с клавиатуры M чисел через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] array = SetNumbers();
PrintArray(array);
Console.WriteLine(CountPositive(array));

int[] SetNumbers()
{
	Console.WriteLine("Enter your numbers separated by commas");
	string input = Console.ReadLine();
	int length = CountChars(input, ',') + 1;
	int[] numbers = new int[length];
	int index = 0;
	string temp = String.Empty;
	for (int i = 0; i < input.Length; i++)
	{
		if (i == input.Length - 1)
		{
			temp += input[i];
			numbers[index] = Convert.ToInt32(temp);
		}
		else if (input[i] != ',')
		{
			temp += input[i];
		}
		else
		{
			numbers[index] = Convert.ToInt32(temp);
			temp = String.Empty;
			index++;
		}
	}
	return numbers;
}
int CountPositive(int[] array)
{
	int count = 0;
	foreach (int num in array)
	{
		if (num > 0) count++;
	}

	return count;
}
int CountChars(string str, char target)
{
	int count = 0;
	for (int i = 0; i < str.Length; i++)
	{
		if (str[i] == target) count++;
	}

	return count;
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
