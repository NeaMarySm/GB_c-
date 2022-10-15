// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//     456 -> 6
//     782 -> 2
//     918 -> 8

Console.WriteLine("Enter 3 digit number");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 100 || num > 999)
{
    Console.WriteLine("Your number is incorrect. Please, enter 3 digit number");
    num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(num % 10);
