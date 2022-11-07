/*
Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.
*/

int[] array = { 1, 8, 14, 12, 9, 0, 13, 88, 11, 5 };
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
ArrayShuffle(ref array);
PrintArray(array);
void ArrayShuffle(ref int[] arr)
{
    int maxIndex = arr.Length - 1;
    int[] newArray = new int[arr.Length];
    int[] indexes = GenerateRandomIndexes(arr.Length);
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[indexes[i]] = arr[i];
    }

    arr = newArray;
}

int[] GenerateRandomIndexes(int length)
{
    int[] indexes = new int[length];
    int randomIndex = 0;
    for (int i = 0; i < length; i++)
    {
        while (IsInArray(indexes, randomIndex))
        {
            randomIndex = new Random().Next(1, length + 1);
        }
        indexes[i] = randomIndex;
    }
    int[] tempArray = new int[length];
    for (int j = 0; j < length; j++)
    {
        tempArray[j] = indexes[j] - 1;
    }
    indexes = tempArray;
    return indexes;
}

bool IsInArray(int[] array, int value)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            result = true;
            break;
        }
        else result = false;
    }
    return result;
}
void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
}
