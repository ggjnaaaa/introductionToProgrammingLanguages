// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
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
// Ищет индексы минимального элемента
int[] FindIndexesMinElement(int[,] array)
{
    int[] indexes = new int[2];
    int min = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }

    return indexes;
}
// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine();
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
            Console.Write(array[i, j] + ",\t ");

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
    
    Console.WriteLine();
}
// Выводит элементы массива в консоль без заданной строки и столбца
void Output2DArrayWithoutRowAndColumn(int[,] array, int[] indexes, string message)
{
    Console.WriteLine();
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (indexes[0] == i) continue;
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
            if (indexes[1] == j) continue;
            else Console.Write(array[i, j] + ",\t ");

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
    
    Console.WriteLine();
    Console.WriteLine($"Минимальное число: {array[indexes[0], indexes[1]]}   в строке {indexes[0] + 1}, в столбце {indexes[1] + 1} (нумерация от 1).");
}

int m = Prompt("Введите количество столбцов в массиве: ");
int n = Prompt("Введите количество строк в массиве: ");
int minElement = 0;
int maxElement = 100;

int[,] array = new int[n, m];
IntRandom2DArray(array, minElement, maxElement);
Output2DArray(array, "Исходный массив: ");

int[] indexes = FindIndexesMinElement(array);
Output2DArrayWithoutRowAndColumn(array, indexes, "Новый массив: ");