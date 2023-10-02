// Вывести первые n строк треугольника Паскаля 

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

///Метод заполнения массива алгоритмом Паскаля:
int[,] FillPascalArray (int numberRows)
{
    int rows = numberRows;
    int columns = numberRows + 2;
    int [,] array = new int [rows, columns];

    array[0, 0 ] = 0;
    array[0, 1 ] = 1;
    array[0, 2 ] = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
    return array;
}
///Метод печати массива Паскаля:
void PrintPascalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = i; k < array.GetLength(0); k++)
        {
            Console.Write("    ");
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) continue;
            Console.Write("{0,4}    ", array[i, j]);
        }
        Console.WriteLine();
    }
}

int numberRows = Prompt("Введите количество строк треугольника Паскаля: ");

int [,] array =  FillPascalArray(numberRows);
Console.WriteLine();

PrintPascalArray(array);