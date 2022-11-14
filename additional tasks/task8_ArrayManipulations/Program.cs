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
int[] userArray = SetNumbers();
PrintArray(userArray);

int[] SetNumbers()
{
	Console.WriteLine("Enter numbers");
	string inputNumbers = Console.ReadLine();
	string[] array = inputNumbers.Split(new char[] { ' ' });
	int[] result = new int[array.Length];
	for (int i = 0; i < array.Length; i++)
	{
		result[i] = Int32.Parse(array[i]);
	}
	return result;
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
// void PrintStrArray(string[] arr)
// {
// 	Console.WriteLine();
// 	foreach (string item in arr)
// 	{
// 		Console.Write(item + " ");
// 	}
// 	Console.WriteLine();
// }
