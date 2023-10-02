// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Отсортировать массив методом пузырька

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
int[] RandomArray(int count)
{
    int[] randomNumbers = new int[count];
    for (int i = 0; i < randomNumbers.Length; i++)
        randomNumbers[i] = new Random().Next(100, 1000);
    return randomNumbers;
}
// Считает количество чётных чисел в массиве
int EvenNumbersCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    
    return count;
}
// Сортировка массива методом пузырька
int[] BubbleArraySort(int[] array)
{
    int temp;

    for (int i = 0; i < array.Length; i++) 
    {
        for (int j = 0; j < array.Length - 1; j++) 
        {
            if (array[j] > array[j + 1]) 
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }

    return array;
}
// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}

int count = Prompt("Введите размер массива: ");
int[] array = RandomArray(count);
Console.Write("Исходный массив: ");
OutputArray(array);

Console.WriteLine($"Количество чётных чисел в массиве: {EvenNumbersCount(array)}");

Console.Write("Отсортированный массив: ");
OutputArray(BubbleArraySort(array));