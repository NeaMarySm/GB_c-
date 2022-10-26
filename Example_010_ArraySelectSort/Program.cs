int[] arr = { 2, 4, 5, 2, 9, 4, 1, 0, 3, 6, 8 };
Sort(arr);
PrintArray(arr);

void PrintArray(int[] array)
{
    foreach (int elem in array)
    {
        Console.Write(elem + " ");
    }
}


void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }
        int temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }
}

