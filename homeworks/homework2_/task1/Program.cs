Console.WriteLine();
Console.WriteLine($"Задание 10");
Console.WriteLine($"Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine();
Console.Write("Введите трёхзначное число: ");

// Ввод числа
string num = Console.ReadLine() ?? ".";
int number = Convert.ToInt32(num);

// Проверка на количество цифр в числе
if (number < 100)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    // Расчёт 2го числа и вывод в консоль
    Console.WriteLine(number % 100 / 10);
}
