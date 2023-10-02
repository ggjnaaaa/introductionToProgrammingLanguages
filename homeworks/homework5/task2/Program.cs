// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
// Найдите все пары в массиве и выведите пользователю

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
int[] RandomArray(int count, int min, int max)
{
    int[] randomNumbers = new int[count];
    for (int i = 0; i < randomNumbers.Length; i++)
        randomNumbers[i] = new Random().Next(min, max);
    return randomNumbers;
}
// Считает сумму элементов, стоящих на нечётных позициях
int OddIndexNumbersSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];

    return sum;
}
// Ищет пары
void PairSearch(int[] array)
{
    List<int> passedIndexes = new List<int>();

    for (int i = 0; i < array.Length - 1; i++)
    {
        bool indexFound = false;
        foreach (int index in passedIndexes)
            if (index == i)
            {
                indexFound = true;
                break;
            }
        if (indexFound) continue;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] == array[i])
            {
                passedIndexes.Add(j);
                PairOutput(array[j], i, j);
                break;
            }
        }
    }
}
// Выводит пары в консоль
void PairOutput(int number, int index1, int index2)
{
    Console.WriteLine($"Пара: {number}, {number}    Индексы: {index1}, {index2}");
}
// Выводит массив в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}

int count = Prompt("Введите размер массива: ");
int[] array = RandomArray(count, 0, 10);
Console.Write("Исходный массив: ");
OutputArray(array);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {OddIndexNumbersSum(array)}");

Console.WriteLine("Пары элементов: ");
PairSearch(array);