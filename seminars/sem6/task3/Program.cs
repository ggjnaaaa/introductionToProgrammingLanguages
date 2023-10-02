// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Переводит число в двоичное
string DecToBin(int number)
{
    return number == 0 ? "" : DecToBin(number / 2) + Convert.ToString(number % 2);
}

int number = Prompt("Введите число: ");

Console.Write($"Двоичное представление числа: {DecToBin(number)}");
