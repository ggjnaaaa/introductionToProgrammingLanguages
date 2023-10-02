// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Закомментированы другие варианты решения

Console.WriteLine("Чтобы выйти введите -1");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");

// Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Кратно" : "Не кратно");

Console.WriteLine();

