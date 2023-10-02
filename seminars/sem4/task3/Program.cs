// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return FactorialCalculation(number);
}

// Проверяет четверть
long FactorialCalculation(int number)
{
    int factorial = 1;
    for (int i = 2; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}

Console.WriteLine(Prompt("Введите число: "));