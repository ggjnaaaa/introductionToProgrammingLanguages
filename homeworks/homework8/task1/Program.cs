// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
// Сортирует массив
void Sort2DArrayByInserts(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Массив - строчка двумерного массива
        int[] rowArray = new int[array.GetLength(0)];

        // Копирование строчки в одномерный массив
        for (int j = 0; j < array.GetLength(1); j++)
            rowArray[j] = array[i, j];

        // Сортировка вставками
        SortingByInserts(rowArray);

        // Обратное копирование
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rowArray[j];
    }
}
// Сортировка массива вставками
void SortingByInserts(int[] array)
{
    int[] sortArray = array;

    for (int i = 1; i < sortArray.Length; i++)
    {
        int k = sortArray[i];
        int j = i - 1;

        while (j >= 0 && sortArray[j] < k)
        {
            sortArray[j + 1] = sortArray[j];
            sortArray[j] = k;
            j--;
        }
    }
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
Output2DArray(array, "Исходный массив: ");

// Сортировка строк
Sort2DArrayByInserts(array);
Output2DArray(array, "Новый массив: ");