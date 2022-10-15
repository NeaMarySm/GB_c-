int[] array = new int[10];

void ArrayFill(int[] array)
{

    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(1, 25);
        index++;
    }
}

void ArrayPrint(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}

ArrayFill(array);
ArrayPrint(array);
Console.WriteLine();

int IndexOf(int[] array, int target)
{
    int index = 0;
    int target_index = -1;
    while (index < array.Length)
    {
        if (array[index] == target)
        {
            target_index = index;
            break;
        }
        else
        {
            index++;
        }
    }

        return target_index; 
    
}


int result = IndexOf(array, 6);
Console.WriteLine(result);


