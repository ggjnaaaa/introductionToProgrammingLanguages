// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Вывести таблицу с границами и значениями друг над другом

// Вывод сообщения и вызов метода OutputSquares
void Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(values);

    OutputSquares(number);
}
// Расчёт квадратов и составление таблицы
void OutputSquares(int number)
{
    Console.Clear();

    int currentNumberCube; // Квадрат нынешнего числа
    int cursorColumn = Console.CursorLeft; // Позиция курсора в строке
    int cursorRow;
    int countLines = 0; // Сколько раз переносилась таблица

    var windowWidth = Console.WindowWidth; // Размер окна консоли
    var windowHeight = Console.WindowHeight;

    // Хранит крайнее положение курсора на каждой строке с квадратами
    Dictionary<int, int> endCursorColumns = new Dictionary<int, int>();

    for (int i = 1; i <= number; i++)
    {
        currentNumberCube = (int)Math.Pow(i, 3);
        string num = Convert.ToString(currentNumberCube);

        // Если нынешнее число не вмещается в активную строку, то осуществляется перенос
        if (cursorColumn + num.Length + 5 > windowWidth)
        {
            cursorRow = Console.CursorTop + 2;

            // Если значения не поместятся в окно консоли
            if (cursorRow + 6 > windowHeight)
            {
                // Записывает значения для последней строки
                endCursorColumns.Add(countLines * 6 + 1, cursorColumn);

                DrawingFrames(endCursorColumns, countLines);

                // Сброс словаря и количества написанных строк таблицы
                endCursorColumns.Clear();
                countLines = 0;
                cursorColumn = Console.CursorLeft;

                for (int h = 0; h < windowHeight; h++)
                    Console.WriteLine();
            }
            else
            {
                endCursorColumns.Add(countLines * 6 + 1, cursorColumn - 2);
                countLines++;
                Console.WriteLine();
                Console.WriteLine();
                while (Console.CursorLeft != cursorColumn - 3)
                    Console.Write("=");
                Console.WriteLine();

                cursorColumn = Console.CursorLeft;
            }
        }

        // Запись числа в консоль
        Console.SetCursorPosition(cursorColumn, countLines * 6 + 1);
        Console.Write("|   ");
        Console.Write(i);

        // Запись квадрата в консоль
        Console.SetCursorPosition(cursorColumn, countLines * 6 + 3);
        Console.Write("|   ");
        Console.Write(currentNumberCube);

        cursorColumn = Console.CursorLeft + 3;
    }
    // Записывает значения для последней строки
    endCursorColumns.Add(countLines * 6 + 1, cursorColumn);

    DrawingFrames(endCursorColumns, countLines);
}
// Рисует рамки таблицы
void DrawingFrames(Dictionary<int, int> endCursorColumns, int countLines)
{
    var windowWidth = Console.WindowWidth;

    for (int i = 0; i <= countLines; i++)
    {
        int temp = endCursorColumns[i * 6 + 1] > windowWidth ? windowWidth - 2 : endCursorColumns[i * 6 + 1] - 2;

        // Границы между строчками таблицы
        for(int j = 0; j <= 4; j += 2)
        {
            Console.SetCursorPosition(0, i * 6 + j);
            while (Console.CursorLeft <= temp)
                Console.Write("-");
        }
        // Крайние левые границы
        for (int j = 1; j <= 3; j += 2)
        {
            Console.SetCursorPosition(temp + 1, i * 6 + j);
            Console.Write("|");
        }
    }
    Console.WriteLine();
}

Prompt("Введите число: ");

