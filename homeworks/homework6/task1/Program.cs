// Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// Вывод сообщения и запись введённых данных
string Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";

    return value;
}

// Подсчёт положительных чисел в строке
int NumberCounter(string value, int count)
{
    int i = 0;
    int result = 0;
    int currentNumber;
    string number = "";

    while(i < count)
    {
        // Если нынешний символ - цифра
        if (int.TryParse(Convert.ToString(value[i]), out currentNumber))
        {
            number += currentNumber;

            // Добавляет "-" числу, если так написал пользователь
            if (i > 0 && Convert.ToString(value[i - 1]) == "-") number = "-" + number;
        }
        // Если не цифра и предыдущий символ был цифрой
        else if (number != "")
        {
            currentNumber = Convert.ToInt32(number);

            // Если число положительное
            if (currentNumber > 0) result++;

            number = "";
        }

        i++;
    }

    return result;
}

int count = Convert.ToInt32(Prompt("Введите число нажатий: "));

Console.WriteLine($"Чисел больше 0: {NumberCounter(Prompt("Введите строку: "), count)}");