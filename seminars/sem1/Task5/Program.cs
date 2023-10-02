// Задача №5
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число:");
int numPositive = int.Parse(Console.ReadLine()??"0");
int numNegative = -1 * numPositive;

for (int i = numNegative; i < numPositive; i++)
{
    Console.Write($"{i}, ");
}
Console.WriteLine($"{numPositive}.");