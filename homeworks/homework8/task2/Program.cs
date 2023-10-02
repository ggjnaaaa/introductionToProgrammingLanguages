// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void IntRandom2DArray(int[,] array, int minElement, int maxElement)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minElement, maxElement + 1);
}
// Поиск минимальной суммы
int SearchMinimumRow2DArray(int[,] array)
{
    // Ключ - номер строки, значение - сумма
    Dictionary<int, int> sums = RowsSum(array);
    int min = sums[0];
    int minIndex = 0;

    for (int i = 1; i < array.GetLength(0); i++)
    {
        bool isMin = sums[i] < min;
        min = isMin ? sums[i] : min;
        minIndex = isMin ? i : minIndex;
    }

    return minIndex;
}
// Записывает суммы строк массива в словарь
Dictionary<int, int> RowsSum(int[,] array)
{
    Dictionary<int, int> sums = new Dictionary<int, int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];

        sums.Add(i, sum);
    }

    return sums;
}
// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.Write(array[i, j] + ",\t ");
        }

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}

// Получение данных от пользователя
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
// Границы рандомного заполнения массива
int minElement = 0;
int maxElement = 10;

// Создание и вывод массива
int[,] array = new int[m, n];
IntRandom2DArray(array, minElement, maxElement);
Output2DArray(array, "Mассив: ");

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {SearchMinimumRow2DArray(array)  + 1}");