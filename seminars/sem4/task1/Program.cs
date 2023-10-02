// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return NumbersSum(number);
}

// Считает сумму
int NumbersSum(int number)
{
    int total = 0;
    for (int i = 1; i <= number; i++)
    {
        total += i;
    }
    return total;
}

Console.WriteLine(Prompt("Введите число: "));