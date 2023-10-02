// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
// Меняет заданные строчки между собой
void ChangingLines(int[,] array, int line1, int line2)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[line1, i];
        array[line1, i] = array[line2, i];
        array[line2, i] = temp;
    }
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

int m = Prompt("Введите количество столбцов в массиве: ");
int n = Prompt("Введите количество строк в массиве: ");
int minElement = 0;
int maxElement = 10;

int[,] array = new int[n, m];
IntRandom2DArray(array, minElement, maxElement);

Output2DArray(array, "Исходный массив: ");

int line1 = Prompt("Введите номер строки, которую хотите сменить (отсчёт с нуля): ");
int line2 = Prompt("Введите номер строки, которую хотите сменить (отсчёт с нуля): ");
ChangingLines(array, line1, line2);

Output2DArray(array, "Новый массив: ");