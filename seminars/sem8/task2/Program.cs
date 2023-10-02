// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
// Меняет строки на столбцы 
int[,] ChangingRowsToColumns(int[,] array)
{
    int[,] temp = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            temp[j, i] = array[i, j];

    return temp;
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

// Получение данных от пользователя
int m = Prompt("Введите количество столбцов в массиве: ");
int n = Prompt("Введите количество строк в массиве: ");
// Границы для случайного заполнения массива 
int minElement = 0;
int maxElement = 10;

// Если массив не квадратный, то выводится сообщение и программа завершается
if (m != n)
{
    Console.WriteLine("Невозможно заменить строки на столбцы.");
    return;
}

int[,] array = new int[n, m];
IntRandom2DArray(array, minElement, maxElement); // Заполнение массива

Output2DArray(array, "Исходный массив: "); // Вывод массива

array = ChangingRowsToColumns(array); // Замена строчек на столбцы 

Output2DArray(array, "Новый массив: "); // Вывод нового массива