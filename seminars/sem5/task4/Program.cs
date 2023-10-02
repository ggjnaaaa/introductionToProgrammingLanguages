// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

// Заполняет массив случайными цифрами
int[] RandomArray()
{
    int[] randNums = new int[123];
    for (int i = 0; i < randNums.Length; i++)
        randNums[i] = new Random().Next(0, 200);
    return randNums;
}
// Считает кол-во чисел 
int CountElements(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] >= 10 && array[i] <= 99) count++;

    return count;
}
// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}

int[] array = RandomArray();
OutputArray(array);
Console.WriteLine($"Количество элементов массива в отрезке [10, 99]: {CountElements(array)}");