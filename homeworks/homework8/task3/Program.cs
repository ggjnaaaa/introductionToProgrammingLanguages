// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] StartingAndCreatingMatrices(string message)
{
    // Получение данных от пользователя
    int m = Prompt($"Введите m (количество строк) для {message} матрицы: ");
    int n = Prompt($"Введите n (количество столбцов) для {message} матрицы: ");
    // Границы рандомного заполнения массива
    int minElement = 0;
    int maxElement = 10;

    // Создание и вывод массива
    int[,] array = new int[m, n];
    IntRandom2DArray(array, minElement, maxElement);
    Output2DArray(array, "Матрица: ");

    return array;
}
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
// Перемножает матрицы
static int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(0)]; 

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(0); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    return result;
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
        {
            Console.Write(array[i, j] + ",\t ");
        }

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }

    Console.WriteLine();
}

// Создание двух матриц
int[,] array1 = StartingAndCreatingMatrices("первой");
int[,] array2 = StartingAndCreatingMatrices("второй");

// Проверка возможности умножения одной матрицы на другую
if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить, число столбцов первой матрицы должно совпадать с числом строк второй матрицы.");
    return;
}

// Умножение матриц и вывод в консоль
int[,] result = MatrixMultiplication(array1, array2);
Output2DArray(result, "Результат: ");