int weight_1 = new Random().Next(1, 10);
int weight_2 = new Random().Next(1, 10);
int weight_3 = new Random().Next(1, 10);
int weight_4 = new Random().Next(1, 10);
int weight_5 = new Random().Next(1, 10);

Console.Write(weight_1);
Console.Write(weight_2);
Console.Write(weight_3);
Console.Write(weight_4);
Console.Write(weight_5);

int max = weight_1;

if (weight_1 > max) { max = weight_1; }
if (weight_2 > max) { max = weight_2; }
if (weight_3 > max) { max = weight_3; }
if (weight_4 > max) { max = weight_4; }
if (weight_5 > max) { max = weight_5; }

Console.WriteLine();
Console.WriteLine(max);
