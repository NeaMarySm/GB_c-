int[,] numbers = new int[2, 5]{{1,2,3,4,5},
						   {0,5,6,7,8}};
int rank = numbers.Rank; //  rank of an array
						 //Console.WriteLine(rank);
int length = numbers.Length; // number of all elements in array
int rows = numbers.GetLength(0); // number of rows
int cols = numbers.GetLength(1); // number of cols

void PrintTwoDimensionalArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}
void FillTwoDimensionalArray(ref int[,] array, int min = -99, int max = 99)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(min, max + 1);
		}
	}
}
PrintTwoDimensionalArray(numbers);