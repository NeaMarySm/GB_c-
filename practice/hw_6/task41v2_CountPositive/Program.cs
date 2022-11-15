
Console.WriteLine("Enter your numbers separated by commas");
string input = Console.ReadLine();
int count = CountPositive(input);
Console.WriteLine(count);

int CountPositive(string str)
{
	int notPositive = 0;
	int length = 0;
	for (int i = 0; i < str.Length; i++)
	{
		if (str[i] == ',')
		{
			length++;
		}
		if (str[i] == '-' || (str[i] == 0 && str[i + 1] == ','))
		{
			notPositive++;
		}
	}
	return length - notPositive;
}
