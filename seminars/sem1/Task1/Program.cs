// Задача №0
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число");

string inputNum = Console.ReadLine()??"0";

int num = int.Parse(inputNum);

Console.WriteLine(num * num);