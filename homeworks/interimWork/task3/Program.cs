// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Функция Аккермана
int AckermanFunction(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AckermanFunction(m - 1, 1);
    else
      return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

// Получение данных от пользователя
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");

// Проверка введённых данных и вывод суммы в консоль
Console.WriteLine($"Результат вычисления функции Аккермана: {AckermanFunction(m, n)}");