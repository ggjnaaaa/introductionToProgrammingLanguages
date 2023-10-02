// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Закомментированы другие варианты решения

Console.WriteLine("Чтобы выйти введите -1");
Console.Write("Введите число: ");
string str = Console.ReadLine()??"0";
string[] stringNums = str.Split(',');

int num1 = Convert.ToInt32(stringNums[0]);
int num2 = Convert.ToInt32(stringNums[1]);

if (num1 % num2 == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {num1 % num2}");

// Console.WriteLine(num1 % num2 == 0 ? "Кратно" : $"Не кратно, остаток {num1 % num2}");

Console.WriteLine();