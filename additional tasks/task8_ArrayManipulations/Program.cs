/* 8. Написать программу со следующими командами:
- SetNumbers – пользователь вводит числа через пробел, а программа запоминает их в массив
- AddNumbers – пользователь вводит числа, которые добавятся к уже существующему массиву
- RemoveNumbers -  пользователь вводит числа, которые если  найдутся в массиве, то будут удалены
- Numbers – ввывод текущего массива
- Sum – найдется сумма всех элементов чисел
По желанию можно добавить методов работы с числовыми массивами:
- найти локальные максимумы
- вывести статистику чисел (в любом красивом виде)
- любые дополнительные по желанию
*/

string[] commands = { "SetNumbers", "AddNumbers", "RemoveNumbers", "Numbers", "Sum", "Max", "Min", "Exit", "Help" };
bool inWork = true;
int[] userArray = SetNumbers();
while (inWork)
{
	Console.WriteLine("Enter Command");
	string command = Console.ReadLine().ToLower();
	switch (command)
	{
		case "exit":
			inWork = false;
			break;
		case "setnumbers":
			userArray = SetNumbers(); ;
			break;
		case "addnumbers":
			int add = ReadInt("Enter number to add: ");
			AddToArray(ref userArray, add);
			break;
		case "removenumbers":
			int del = ReadInt("Enter number to remove: ");
			RemoveValueFromArray(ref userArray, del);
			break;
		case "numbers":
			PrintArray(userArray);
			break;
		case "sum":
			Console.WriteLine($"Sum of elements: {ArraySum(userArray)}");
			break;
		case "min":
			Console.WriteLine($"Min value: {FindMin(userArray)}");
			break;
		case "max":
			Console.WriteLine($"Max value: {FindMax(userArray)}");
			break;
		case "help":
			PrintCommands(commands);
			break;

		default:
			Console.WriteLine("Unknown command");
			break;
	}

}

void PrintCommands(string[] arr)
{
	Console.WriteLine("available commands:");
	foreach (string item in arr)
	{
		Console.WriteLine(item);
	}
	Console.WriteLine();
}

int[] SetNumbers()
{
	Console.WriteLine("Enter numbers separated by spaces");
	string inputNumbers = Console.ReadLine();
	string[] array = inputNumbers.Split(new char[] { ' ' });
	int[] result = new int[array.Length];
	for (int i = 0; i < array.Length; i++)
	{
		result[i] = Int32.Parse(array[i]);
	}
	return result;
}

int ArraySum(int[] array)
{
	int result = 0;
	foreach (int num in array)
	{
		result += num;
	}
	return result;
}

void AddToArray(ref int[] arr, int value)
{
	int[] newArray = new int[arr.Length + 1];
	for (int i = 0; i < arr.Length; i++)
	{
		newArray[i] = arr[i];
	}
	newArray[arr.Length] = value;
	arr = newArray;
}

void RemoveValueFromArray(ref int[] arr, int value)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] == value)
		{
			RemoveFromArray(ref arr, i);
		}
	}
}

void RemoveFromArray(ref int[] arr, int index)
{
	if (index > arr.Length - 1 || index < 0)
		return;
	int[] newArray = new int[arr.Length - 1];
	int newArrayIndex = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (i != index)
		{
			newArray[newArrayIndex] = arr[i];
			newArrayIndex++;
		}
	}
	arr = newArray;
}

int FindMax(int[] array)
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

int FindMin(int[] array)
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

void PrintArray(int[] arr)
{
	Console.WriteLine();
	foreach (int item in arr)
	{
		Console.Write(item + " ");
	}
	Console.WriteLine();
}

int ReadInt(string message)
{
	Console.WriteLine(message);
	return Convert.ToInt32(Console.ReadLine());
}