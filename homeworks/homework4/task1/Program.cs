// №25 Написать калькулятор с операциями +, -, /, * и возведение в степень

// Начало программы
void Start()
{
    Console.WriteLine("КАЛЬКУЛЯТОР");
    Console.WriteLine("\"+\" - сложение");
    Console.WriteLine("\"-\" - вычитание");
    Console.WriteLine("\"*\" - умножение");
    Console.WriteLine("\"/\" - деление");
    Console.WriteLine("\"^\" - возведение в степень");
    Console.WriteLine("Вещественные числа через запятую или точку.");

    Prompt("Напишите пример в фромате \"2^2\" и нажмите Enter");
}
// Вывод сообщения и вызов метода CheckOperation
void Prompt(string message)
{
    Console.WriteLine();
    Console.WriteLine(message);
    Console.WriteLine();
    string values = Console.ReadLine()??",";

    CheckOperation(values);
}
// Проверка операции и перенаправление в нужный метод
void CheckOperation(string values)
{
    string[] symbols = { "+", "*", "/", "-", "^" };
    int symbolIndex = 0;
    string[] splitedPrimer = new string[2];

    for (int i = 0; i < 5; i++)
    {
        string[] primer = values.Split(symbols[i]);
        if (primer.Length == 2)
        {
            symbolIndex = i;
            splitedPrimer = primer;
            break;
        }
        else if (primer.Length > 2)
        {
            Console.WriteLine("Неверный ввод данных.");
        }
    }

    switch(symbolIndex)
    {
        case 0: Console.WriteLine(Summation(splitedPrimer)); break;
        case 1: Console.WriteLine(Multiplication(splitedPrimer)); break;
        case 2: Console.WriteLine(Division(splitedPrimer)); break;
        case 3: Console.WriteLine(Subtraction(splitedPrimer)); break;
        case 4: Console.WriteLine(Exponentiation(splitedPrimer)); break;
        default: break;
    }
}
// Сложение
string Summation(string[] primerArrayString)
{
    double[] primerArrayDouble = NumToDouble(primerArrayString);

    return $"Ответ: {primerArrayDouble[0] + primerArrayDouble[1]}";
}
// Умножение
string Multiplication(string[] primerArrayString)
{
    double[] primerArrayDouble = NumToDouble(primerArrayString);

    return $"Ответ: {primerArrayDouble[0] * primerArrayDouble[1]}";
}
// Деление
string Division(string[] primerArrayString)
{
    double[] primerArrayDouble = NumToDouble(primerArrayString);

    return $"Ответ: {primerArrayDouble[0] / primerArrayDouble[1]}";
}
// Вычитание
string Subtraction(string[] primerArrayString)
{
    double[] primerArrayDouble = NumToDouble(primerArrayString);

    return $"Ответ: {primerArrayDouble[0] - primerArrayDouble[1]}";
}
// Возведение в степень
string Exponentiation(string[] primerArrayString)
{
    double[] primerArrayDouble = NumToDouble(primerArrayString);
    int originalNum = Convert.ToInt32(primerArrayDouble[0]);

    for (int i = 1; i < primerArrayDouble[1]; i++)
        primerArrayDouble[0] *= originalNum;

    return $"Ответ: {primerArrayDouble[0]}";
}
// Перевод чисел из строк в вещественные
double[] NumToDouble(string[] primerArrayString)
{
    double[] primerArrayDouble = new double[2];

    for (int i = 0; i < primerArrayString.Length; i++)
    {
        primerArrayDouble[i] = double.Parse(primerArrayString[i].Replace(".", ","));
    }

    return primerArrayDouble;
}

Start();