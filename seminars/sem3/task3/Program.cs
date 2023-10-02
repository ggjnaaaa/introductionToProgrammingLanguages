// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве

// Вывод сообщения и вызов метода DistanceCalculation
double Prompt(string message1, string message2)
{
    Console.WriteLine(message1);
    string values = Console.ReadLine()??",";

    values += ",";

    Console.WriteLine(message2);
    values += Console.ReadLine()??",";

    string[] valuesArray = values.Split(",");
    int xA = Convert.ToInt32(valuesArray[0]);
    int yA = Convert.ToInt32(valuesArray[1]);
    int xB = Convert.ToInt32(valuesArray[2]);
    int yB = Convert.ToInt32(valuesArray[3]);

    return DistanceCalculation(xA, yA, xB, yB);
}

// Расчёт расстояния
double DistanceCalculation(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2) + Math.Pow(Math.Abs(yA - yB), 2));
}

Console.WriteLine(Prompt("Введите 2 числа через запятую (координаты первой точки): ", "Введите 2 числа через запятую (координаты второй точки): "));