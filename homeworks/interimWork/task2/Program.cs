// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Вычисление суммы
int SumNaturalElementsRec(int m, int n)
{
    return n > m ? m + SumNaturalElementsRec(m + 1, n) : m;
}

// Получение данных от пользователя
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");

// Проверка введённых данных и вывод суммы в консоль
int sum = n > m ? SumNaturalElementsRec(m, n) : SumNaturalElementsRec(n, m);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");