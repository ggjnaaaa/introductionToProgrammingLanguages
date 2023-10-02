// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Закомментированы другие варианты решения

Console.Write("Введите число: ");
string str = Console.ReadLine()??"0";
string[] stringNums = str.Split(',');

int num1 = Convert.ToInt32(stringNums[0]);
int num2 = Convert.ToInt32(stringNums[1]);

if (Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1) Console.WriteLine("Да");
else Console.WriteLine("Нет");

Console.WriteLine();
