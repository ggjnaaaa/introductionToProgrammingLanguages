// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Считает длинну числа
int NumberLength(int number)
{
    int length = 0;
    while (number != 0)
    {
        number /= 10;
        length++;
    }
    return length;
}

int number = Prompt("Введите число: ");
Console.WriteLine(NumberLength(number));