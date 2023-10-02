// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов

// Вывод сообщения и запись введённых данных
int[] Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    string[] numsString = value.Replace(".", ",").Split(",");

    int[] numbers = new int [2];
    for (int i = 0; i < numsString.Length; i++)
        numbers[i] = int.Parse(numsString[i]);

    return numbers;
}
// Заполняет массив случайными цифрами
int[] RandomArray(int count, int min, int max)
{
    int[] randNums = new int[count];
    for (int i = 0; i < randNums.Length; i++)
        randNums[i] = new Random().Next(min, max + 1);
    return randNums;
}
// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ",");
    Console.Write(array[array.Length - 1] + "]");
}

int[] count = Prompt("Введите размер массива: ");
int[] minMax = Prompt("Введите диапозон чисел в массиве (например: 1,2): ");

int[] array = RandomArray(count[0], minMax[0], minMax[1]);
OutputArray(array);
