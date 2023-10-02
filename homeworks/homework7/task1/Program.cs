// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
// При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void DoubleRandom2DArray(double[,] array, int minElement, int maxElement)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(rnd.Next(minElement, maxElement + 1) + rnd.NextDouble(), 2);
}
// Выводит элементы массива в консоль
void Output2DArray(double[,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        OutputColorChar("{");

        for (int j = 0; j < array.GetLength(1); j++)
        {
            string element = Convert.ToString(array[i, j]);
            for (int k = 0; k < element.Length; k++)
            {
                OutputColorChar(Convert.ToString(element[k]));
            }

            if (j != array.GetLength(1) - 1)
            {
                OutputColorChar(",\t ");
            }
        }

        OutputColorChar("}\n");
    }

    Console.ResetColor();
}
// Принимает символ и выводит его с рандомным цветом в консоль
void OutputColorChar(string element)
{
    Random rnd = new Random();
    ConsoleColor[] colors = { ConsoleColor.Gray, ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Cyan,
                            ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.Blue, ConsoleColor.DarkGreen,
                            ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.Yellow, ConsoleColor.White,
                            ConsoleColor.Green, ConsoleColor.DarkYellow, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta };

    Console.ForegroundColor = colors[rnd.Next(0, colors.Length)];
    Console.Write(element);
}

// Смена параметров локализации для точки в вещественных числах
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
int minElement = 0;
int maxElement = 10;

double[,] array = new double[m, n];
DoubleRandom2DArray(array, minElement, maxElement);
Output2DArray(array, "Массив: ");