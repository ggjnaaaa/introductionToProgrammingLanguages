// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

// Вывод сообщения и разбивка введённых данных в переменные
int Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine()??",";
    string[] valuesArray = values.Split(",");
    int x = Convert.ToInt32(valuesArray[0]);
    int y = Convert.ToInt32(valuesArray[1]);

    return CheckingQuarter(x, y);
}

// Проверяет четверть
int CheckingQuarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine(Prompt("Введите 2 числа через запятую: "));