// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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
    int[] randomNumber = new int[count];
    for (int i = 0; i < randomNumber.Length; i++)
        randomNumber[i] = new Random().Next(min, max);
    return randomNumber;
}
// Переворачивает массив
void ReverseArray(int[] array)
{
    int count = array.Length / 2;
    int temp;
    
    // перебор элементов 
    for (int i = 0; i < count; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
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
int[] array = RandomArray(count, 0, 15);
Console.Write("Массив: ");
OutputArray(array);

ReverseArray(array);
Console.Write($"Новый массив: ");
OutputArray(array);