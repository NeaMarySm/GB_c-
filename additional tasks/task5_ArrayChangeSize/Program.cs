
/*
...Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – первая добавляет к числовому массиву значение, тем самым увеличивая массив, 
а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.

Нельзя использовать Resize и любые другие встроенные методы массивов

*/

int[] array = { 1, 8, 14, 12, 9, 0 };

printArray(array);
Console.WriteLine();
AddToArray(ref array, 33);
AddToArray(ref array, 2);
AddToArray(ref array, 5);
printArray(array);
Console.WriteLine();
RemoveFromArray(ref array, 3);
printArray(array);

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

void printArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
}
