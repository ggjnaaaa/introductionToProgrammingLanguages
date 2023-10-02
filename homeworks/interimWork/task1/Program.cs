// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Формирование строки с числами
string SearchForNaturalElementsRec(int n)
{
    return n > 1 ? $"{n}, " + SearchForNaturalElementsRec(n - 1) : $"{n}.";
}

// Получение данных от пользователя
int n = Prompt("Введите n: ");

// Вывод суммы
Console.WriteLine(SearchForNaturalElementsRec(n));