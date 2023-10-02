var days = new Dictionary<int, string>()
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"}
};

Console.WriteLine();
Console.WriteLine($"Задание 15");
Console.WriteLine($"Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine();
Console.Write("Введите число: ");

// Ввод числа
string num = Console.ReadLine() ?? ".";
int number = Convert.ToInt32(num);

string value;
if (!days.TryGetValue(number, out value)) Console.WriteLine("Число не является днём недели");
else Console.WriteLine(value);