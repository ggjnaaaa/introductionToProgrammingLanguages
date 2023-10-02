// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
int[] RandomArray(int count)
{
    int[] randNums = new int[count];
    for (int i = 0; i < randNums.Length; i++)
        randNums[i] = new Random().Next();
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
void InversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
}

int count = Prompt("Введите размер массива: ");
int[] array = RandomArray(count);
Console.Write("Старый массив: ");
OutputArray(array);
Console.Write($"Новый массив: ");
InversArray(array);
OutputArray(array);