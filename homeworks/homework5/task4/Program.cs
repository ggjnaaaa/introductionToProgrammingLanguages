// Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом.
// Для задачи со звездочкой использовать заполнение массива целыми числами.

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
// Сортировка массива вставками
void SortingByInserts(int[] array)
{
    int[] sortArray = array;

    for (int i=1; i < sortArray.Length; i++)
    {
        int k = sortArray[i];
        int j = i - 1;

        while(j>=0 && sortArray[j] > k)
        {
            sortArray[j + 1] = sortArray[j];
            sortArray[j] = k;
            j--;
        }
    }
}
// Сортировка подсчетом
void CountingSort(int[] array)
{
    // Поиск минимального и максимального значений
    var min = array[0];
    var max = array[0];
    foreach (int element in array)
    {
        if (element > max)
        {
            max = element;
        }
        else if (element < min)
        {
            min = element;
        }
    }

    // Поправка
    var correctionFactor = min != 0 ? -min : 0;
    max += correctionFactor;

    var count = new int[max + 1];
    for (var i = 0; i < array.Length; i++)
    {
        count[array[i] + correctionFactor]++;
    }

    var index = 0;
    for (var i = 0; i < count.Length; i++)
    {
        for (var j = 0; j < count[i]; j++)
        {
            array[index] = i - correctionFactor;
            index++;
        }
    }
}
// Вычитает мин из макс
double SubtractingElements(int[] array)
{
    return array[array.Length - 1] - array[0];
}
// Выводит элементы массива в консоль
void OutputArray(int[] array, string message)
{
    Console.Write(message);
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}

int count = Prompt("Введите размер массива 1: ");

int[] array1 = RandomArray(count, 0, 15);
OutputArray(array1, "Исходный массив: ");

SortingByInserts(array1);
OutputArray(array1, "Сортировка вставками: ");

Console.WriteLine();

count = Prompt("Введите размер массива 2: ");

int[] array2 = RandomArray(count, 0, 15);
OutputArray(array2, "Исходный массив: ");

CountingSort(array2);
OutputArray(array2, "Сортировка подсчетом: ");

Console.WriteLine();
Console.WriteLine($"Разница между мин и макс в массиве 1: {SubtractingElements(array1)}");
Console.WriteLine($"Разница между мин и макс в массиве 2: {SubtractingElements(array2)}");