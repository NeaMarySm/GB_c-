// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Enter first number");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum){
    Console.WriteLine("max = " + firstNum);
    Console.WriteLine("min = " + secondNum);
} else if(firstNum == secondNum){
    Console.WriteLine("Nubmbers are equal ");
} else {
    Console.WriteLine("max = " + secondNum);
    Console.WriteLine("min = " + firstNum);
}