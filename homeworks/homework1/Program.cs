// Навигация между заданиями
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

// Массивы для вывода в консоль
string[] consoleSrings1 = { "два числа и выдаёт, какое число большее, а какое меньшее.",
"три числа и выдаёт максимальное из этих чисел.",
"число и выдаёт, является ли число чётным",
"число N, а на выходе показывает все чётные числа от 1 до N."};

string[] consoleSrings2 = { "Введите два числа через точку с запятой (;) без пробелов (вещественные числа с запятой): ",
"Введите три числа через точку с запятой (;) без пробелов (вещественные числа с запятой): ",
"Введите число (вещественные числа с запятой): ",
"Введите число (вещественные числа с запятой): "};

// Возвращается сюда если пользователь решил вернуться в главное меню
newAttempt1:
Console.WriteLine();
Console.WriteLine("Выберите задание:");
Console.WriteLine("1 - задание 1");
Console.WriteLine("2 - задание 2");
Console.WriteLine("3 - задание 3");
Console.WriteLine("4 - задание 4");
Console.WriteLine();
Console.WriteLine("0 - выйти");
Console.WriteLine();
Console.WriteLine("Ответ: ");

// Возвращается сюда если был введён не тот ответ в главном меню
newAttempt2:
string? answer = Console.ReadLine();
int answerInt;

// Проверка на целое число, если строка не является числом, то программа возвращается к newAttempt2
if (!int.TryParse(answer, out answerInt))
{
    Console.WriteLine("Вы ввели не тот символ, повторите попытку...");
    goto newAttempt2;
}

// Строка для записи ответа пользователя, который он даст в одном из заданий
string answerString;

// Возвращается сюда если пользователь решит снова запустить то же задание
replay:
switch (answerInt)
{
    case 0: return;
    case 1: answerString = task1(); break;
    case 2: answerString = task2(); break;
    case 3: answerString = task3(); break;
    case 4: answerString = task4(); break;
    default: return;
}

// Проверка ответа пользователя
if (answerString == "0") return;
else if (answerString.ToLower() == "m") goto newAttempt1;
else {
    switch (answerString)
    {
        case "1": answerInt = 1; goto replay;
        case "2": answerInt = 2; goto replay;
        case "3": answerInt = 3; goto replay;
        case "4": answerInt = 4; goto replay;
        default : Console.WriteLine("Вы ввели не тот символ"); return;
    }
}

// Задание 1
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
string task1()
{
    startProgram(1);

    // Запись введённых чисел в массив
    string nums = Console.ReadLine()??".";
    string[] numsStringArray = nums.Split(new char[] { ';' });
    double[] numsDoubleArray = new double[2];

    // Проверка массива
    if (numsStringArray.Length == 2)
    {
        int i = 0;
        // Перебор элементов массива строк
        foreach (string number in numsStringArray)
        {
            // Попытка сделать из строки вещественное число, запись чисел в массив вещественных чисел
            if (!double.TryParse(number, out numsDoubleArray[i]))
                return endOfProgram("error", "1");
            i++;
        }
    }
    else
    {
        // Если массив получился не из двух элементов, то идёт проверка: либо пользователь взаимодействовал с навигацией, либо допустил ошибку при вводе
        if (numsStringArray[0].ToLower() == "m" || numsStringArray[0] == "0") return numsStringArray[0];
        else return endOfProgram("error", "1");
    }

    // Вывод макс и мин чисел
    Console.WriteLine("Максимальное: " + Math.Max(numsDoubleArray[0], numsDoubleArray[1]));
    Console.WriteLine("Минимальное: " + Math.Min(numsDoubleArray[0], numsDoubleArray[1]));

    return endOfProgram("end", "1");
}

// Задание 2
// Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел
string task2()
{
    startProgram(2);

    // Запись введённых чисел в массив
    string nums = Console.ReadLine()??".";
    string[] numsStringArray = nums.Split(new char[] { ';' });
    double[] numsDoubleArray = new double[3];

    // Проверка массива
    if (numsStringArray.Length == 3)
    {
        int i = 0;
        // Перебор элементов массива сток
        foreach (string number in numsStringArray)
        {
            // Попытка сделать из строки вещественное число, запись чисел в массив вещественных чисел
            if (!double.TryParse(number, out numsDoubleArray[i]))
                return endOfProgram("error", "2");
            i++;
        }
    }
    else
    {
        // если массив получился не из трёх элементов, то идёт проверка: либо пользователь взаимодействовал с навигацией, либо допустил ошибку при вводе
        if (numsStringArray[0].ToLower() == "m" || numsStringArray[0] == "0") return numsStringArray[0];
        else return endOfProgram("error", "2");
    }

    // Поиск максимального числа
    double max = numsDoubleArray[0];
    for (int i = 1; i < 3; i++)
        if (max < numsDoubleArray[i]) max = numsDoubleArray[i];

    // Вывод максимального числа
    Console.WriteLine($"Максимальное: {max}");

    return endOfProgram("end", "2");
}

// Задание 3 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
string task3()
{
    startProgram(3);

    // Ввод числа
    string numString = Console.ReadLine()??".";
    double number;

    // Проверка строки и попытка приведения её в вещественное число
    if (numString.ToLower() == "m" || numString == "0") return numString;
    else
    if (!double.TryParse(numString, out number))
    {
        return endOfProgram("error", "3");
    }

    // Проверка на чётность
    if (number % 2 == 0) Console.WriteLine("Да");
    else Console.WriteLine("Нет");

    return endOfProgram("end", "3");
}

// Задание 4
// Напишите программу, которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N
string task4()
{
    startProgram(4);

    // Ввод числа
    string num = Console.ReadLine()??".";
    double number;

    // Проверка строки и попытка приведения её в вещественное число
    if (num.ToLower() == "m" || num == "0") return num;
    else
    if (!double.TryParse(num, out number))
    {
        return endOfProgram("error", "4");
    }

    // Вывод чётных чисел
    int i = 2;
    if (i > number) Console.WriteLine("Таких чисел нет");
    while (i < number)
    {
        Console.Write($"{i}, ");
        i += 2;
    }
    Console.WriteLine($"{number}.");

    return endOfProgram("end", "4");
}

// Прочее
// Метод используется при старте любого задания
void startProgram(int task)
{
    Console.WriteLine();
    Console.WriteLine($"Задание {task}");
    Console.WriteLine($"Напишите программу, которая на вход принимает {consoleSrings1[task-1]}");
    Console.WriteLine("Чтобы выйти в главное меню введите m. Чтобы завершить программу введите 0.");
    Console.WriteLine();
    Console.Write(consoleSrings2[task-1]);
}

// Метод используется при ошибке или окончании любого задания
string endOfProgram(string version, string task)
{
    if (version == "error")
    {
        Console.WriteLine();
        Console.WriteLine("Вы допустили ошибку при вводе данных.");
    }

    Console.WriteLine();
    Console.WriteLine("m - выход в главное меню");
    Console.WriteLine($"{task} - новая попытка");

    newAttempt:
    string answer = Console.ReadLine() ?? ".";

    if (answer.ToLower() != "m" && answer != task)
    {
        Console.WriteLine("Вы ввели не тот символ, повторите попытку...");
        goto newAttempt;
    }
    else return answer;
}