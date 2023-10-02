// Задача 67
// принимает на вход число и возвращает сумму числа

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Считает сумму
int SumOfNumberRec(int number)
{
    string numString = Convert.ToString(number);
    return numString.Length <= 0 
    ? 0
    : Convert.ToInt32(Convert.ToString(numString[numString.Length - 1])) + SumOfNumberRec(number / 10);
}

// Считает сумму
int SumOfNumberRec(int number)
{
    return number <= 0 
    ? 0
    : number % 10 + SumOfNumberRec(number / 10);
}

int number = Prompt("Введите число: ");

Console.WriteLine(SumOfNumberRec(number));