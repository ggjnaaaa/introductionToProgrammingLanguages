//#69 Напишите программу, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Считает сумму
int Exponentiation(int number, int stepen)
{
    return stepen == 2 
    ? number * number
    : stepen <= 1 
        ? number 
        : stepen % 2 == 0 
            ? Exponentiation(number, stepen / 2) * Exponentiation(number, stepen / 2)
            : Exponentiation(number, stepen / 2 + 1) * Exponentiation(number, stepen / 2);
}

int number = Prompt("Введите число: ");
int stepen = Prompt("Введите степень: ");

Console.WriteLine($"Число {number} в степени {stepen} = {Exponentiation(number, stepen)}");