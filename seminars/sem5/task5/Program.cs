// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
int[] RandomArray(int count, int min, int max)
{
    int[] randNums = new int[count];
    for (int i = 0; i < randNums.Length; i++)
        randNums[i] = new Random().Next(min, max);
    return randNums;
}
// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}
// Меняет знак элементов массива
int[] SumOfPairs(int[] array)
{
    bool arrayLengthIsEven = array.Length % 2 == 0 ? true : false; // длинна массива чётная?
    int count = arrayLengthIsEven ? array.Length / 2 : array.Length / 2 + 1; // если нечётная, то +1 к половине длины исходного массива, чтобы не потерять средний элемент
    int[] sumArray = new int[count];

    count = array.Length / 2;

    // перебор элементов до середины
    for (int i = 0; i < count; i++)
    {
        sumArray[i] = array[i] * array[array.Length - 1 - i];
    }

    // если среднего элемента нет, то остаётся тот же результат, иначе в конец массива добавляется средний элемент
    sumArray[sumArray.Length - 1] = arrayLengthIsEven ? sumArray[sumArray.Length - 1] : array[count];

    return sumArray;
}

int count = Prompt("Введите размер массива: ");
int[] array = RandomArray(count, 0, 15);
Console.Write("Массив: ");
OutputArray(array);

int[] sumArray = SumOfPairs(array);
Console.Write($"Новый массив: ");
OutputArray(sumArray);