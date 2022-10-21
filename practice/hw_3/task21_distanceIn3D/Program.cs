/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Enter coordinate of the point A:");
int ax = ReadInt();
int ay = ReadInt();
int az = ReadInt();

Console.WriteLine("Enter coordinate of the point B:");
int bx = ReadInt();
int by = ReadInt();
int bz = ReadInt();

double distance = CountDistance(ax, bx, ay, by, az, bz);
Console.WriteLine(distance);

int ReadInt()
{
    return Convert.ToInt32(Console.ReadLine());
}
double CountDistance(int ax, int bx, int ay, int by, int az, int bz)
{
    int sumOfSquares = (bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az);
    return Math.Sqrt(sumOfSquares);

}