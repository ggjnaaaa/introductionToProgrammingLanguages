// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Сделать оценку времени алгоритма через вещественные числа и строки

// Вывод сообщения
int Prompt(string message1)
{
    Console.WriteLine(message1);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Сумма цифр через while
int SumWhile(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

// Сумма цифр через строки
int SumString(int number)
{
    string num = Convert.ToString(number);
    int sum = 0;

    for (int i = 0; i < num.Length; i++)
    {
        sum += Convert.ToInt32(Convert.ToString(num[i]));
    }

    return sum;
}

int number = Prompt("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = SumWhile(number);
Console.WriteLine($"Время через while: {DateTime.Now - d1}");

DateTime d2 = DateTime.Now;
int res2 = SumString(number);
Console.WriteLine($"Время через string: {DateTime.Now - d2}");

Console.WriteLine($"Результат через while: {res1}");
Console.WriteLine($"Результат через string: {res2}");