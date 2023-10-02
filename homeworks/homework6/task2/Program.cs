// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Найдите площадь треугольника образованного пересечением 3 прямых
// b1 = 2, k1 = 5, b2 = 4, k2 = 9

// Вывод сообщения и запись введённых данных
void Prompt(string message, int num, out Variables variables)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    value = value.Replace($"b{num}", "").Replace($"k{num}", "").Replace("=", "");

    // Преобразование строки в массив
    string[] values = value.Split(',');
    int[] numbers = new int[values.Length];

    for (int i = 0; i < values.Length; i++)
        numbers[i] = Convert.ToInt32(values[i]);

    // Запись значений b и k в структуру
    variables = new Variables(numbers[0], numbers[1]);
}

// Поиск пересечений
void FindingIntersections(Variables numbers1, Variables numbers2, out Point point)
{
    double x = (double)-(numbers1.b - numbers2.b) / (numbers1.k - numbers2.k);
    double y = numbers1.k * x + numbers1.b;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    point = new Point(x, y);
}

// Считает площадь треугольника
double CalculatingSquareTriangle(Point point1, Point point2, Point point3)
{
    return 0.5 * Math.Abs(
        (point2.x - point1.x) * (point3.y - point1.y)
        - (point3.x - point1.x) * (point2.y - point1.y));
}

Prompt("Введите значения b1 и k1 (b1 = 2, k1 = 5): ", 1, out Variables numbers1);
Prompt("Введите значения b2 и k2 (b2 = 2, k2 = 5): ", 2, out Variables numbers2);
Prompt("Введите значения b3 и k3 (b3 = 2, k3 = 5): ", 3, out Variables numbers3);

FindingIntersections(numbers1, numbers2, out Point point1);
FindingIntersections(numbers1, numbers3, out Point point2);
FindingIntersections(numbers2, numbers3, out Point point3);

Console.WriteLine($"Координаты точки 1: x: {point1.x}    y: {point1.y}");
Console.WriteLine($"Координаты точки 2: x: {point2.x}    y: {point2.y}");
Console.WriteLine($"Координаты точки 3: x: {point3.x}    y: {point3.y}");

Console.WriteLine($"Площадь треугольника: {CalculatingSquareTriangle(point1, point2, point3)}");


// Структуры чтобы не хранить кучу переменных
// Координаты точек
struct Point
{
    public double x;
    public double y;
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}
// Значения переменных
struct Variables
{
    public double b;
    public double k;
    public Variables(double b, double k)
    {
        this.b = b;
        this.k = k;
    }
}