// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = ReadNumber("Enter k1: ");
double k2 = ReadNumber("Enter k2: ");
double b1 = ReadNumber("Enter b1: ");
double b2 = ReadNumber("Enter b2: ");

if (isEqual(k1, b1, k2, b2))
{
	Console.WriteLine("The lines are equal");
}
else if (isParallel(k1, k2))
{
	Console.WriteLine("The lines are parallel");
}
else
{
	double[] intersection = findIntersection(k1, b1, k2, b2);
	Console.WriteLine($"({intersection[0]}, {intersection[1]})");
}

bool isEqual(double k1, double b1, double k2, double b2)
{
	bool res = false;
	if (k1 == k2 && b1 == b2) res = true;
	return res;
}

bool isParallel(double k1, double k2)
{
	bool res = false;
	if (k1 == k2) res = true;
	return res;
}

double[] findIntersection(double k1, double b1, double k2, double b2)
{
	double[] coordinates = new double[2];
	coordinates[0] = (b2 - b1) / (k1 - k2);
	coordinates[1] = k1 * coordinates[0] + b1;
	return coordinates;
}

double ReadNumber(string message)
{
	Console.WriteLine(message);
	return Convert.ToDouble(Console.ReadLine());
}