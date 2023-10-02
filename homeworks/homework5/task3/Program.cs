// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
double[] RandomArray(int count, int min, int max)
{
    double[] randomNumbers = new double[count];
    Random rand = new Random();
    for (int i = 0; i < randomNumbers.Length; i++)
        randomNumbers[i] = rand.Next(min, max) + Math.Round(rand.NextDouble(), 3);
    return randomNumbers;
}
// Вычитает мин из макс
double SubtractingElements(double[] array)
{
    return SearchMaxElement(array) - SearchMinElement(array);
}
// Ищет макс элемент
double SearchMaxElement(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    
    return max;
}
// Ищет мин элемент
double SearchMinElement(double[] array)
{
    double min = array[0];
    
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    
    return min;
}
// Выводит массив в консоль
void OutputArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Смена параметров локализации для точки в вещественных чисел
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

int count = Prompt("Введите размер массива: ");
double[] array = RandomArray(count, 0, 10);
Console.Write("Исходный массив: ");
OutputArray(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {SubtractingElements(array)}");