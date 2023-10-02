// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

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
        randNums[i] = new Random().Next(-9, 10);
    return randNums;
}
// Считает сумму 
int Sum(int[] array, int negativeOrPositive)  // negative = 0, рositive = 1
{
    int sum = 0;
    if (negativeOrPositive == 1)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0) sum += array[i];
    }
    else 
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] < 0) sum += array[i];
    }

    return sum;
}
// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write(array[array.Length - 1] + "]");
}

int count = Prompt("Введите размер массива: ");
int[] array = RandomArray(count);
Console.WriteLine($"Сумма отрицательных чисел: {Sum(array, 0)}");
Console.WriteLine($"Сумма положительных чисел: {Sum(array, 1)}");
OutputArray(array);