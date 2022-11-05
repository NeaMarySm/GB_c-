
/*
...Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – первая добавляет к числовому массиву значение, тем самым увеличивая массив, 
а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.

Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.

*/

int[] array = { 1, 8, 14, 12, 9, 0, 13, 88, 11, 5 };

PrintArray(array);

Console.WriteLine("Add:");
AddToArray(ref array, 33);
PrintArray(array);

Console.WriteLine("Remove:");
RemoveFromArray(ref array, 3);
PrintArray(array);

Console.WriteLine("Shuffled array:");
ArrayShuffle(ref array);
PrintArray(array);

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
    for (int i = 0; i < length; i++)
    {
        int index = new Random().Next(0, array.Length);
        newArray[i] = array[index];
        RemoveFromArray(ref array, index);
    }
    array = newArray;
}
