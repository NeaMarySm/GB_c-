/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m = 2;
int n = 3;
int result = Akkerman(m, n);
// int result = Akkerman(n, m);
// int result = Akkerman(0, n);
// int result = Akkerman(m, 0);

Console.WriteLine(result);

int Akkerman(int m, int n)
{
	if (m == 0) return n + 1;
	else if (n == 0) return Akkerman(m - 1, 1);
	else return Akkerman(m - 1, Akkerman(m, n - 1));
}

