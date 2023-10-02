Console.WriteLine();
Console.WriteLine($"Задание 13");
Console.WriteLine($"Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine();
Console.Write("Введите число: ");

// Ввод числа
string num = Console.ReadLine() ?? ".";
int number = Convert.ToInt32(num);

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    // Очистка числа до первых трёх знаков
    while (number >= 1000)
        number /= 10;

    // Вывод в консоль
    Console.WriteLine(number % 10);
}
