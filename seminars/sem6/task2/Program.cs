// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Вывод сообщения и запись введённых данных
int[] Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";

    return StringToIntArray(value);
}
// Преобразовывает строку в массив чисел
int[] StringToIntArray(string value)
{
    string[] values = value.Split(",");
    int[] triangleSides = new int[values.Length];

    for (int i = 0; i < values.Length; i++)
        triangleSides[i] = Convert.ToInt32(values[i]);
    
    return triangleSides;
}
// Проверяет, может ли существовать треугольник
bool CheckTriangle(int[] triangleSides)
{
    return (triangleSides[0] < triangleSides[1] + triangleSides[2]) 
            && (triangleSides[1] < triangleSides[0] + triangleSides[2]) 
            && (triangleSides[2] < triangleSides[0] + triangleSides[1]) ;
}

int[] triangleSides = Prompt("Введите стороны треугольника через запятую: ");

Console.Write(CheckTriangle(triangleSides) ? "Треугольник со сторонами такой длины МОЖЕТ существовать." : "Треугольник со сторонами такой длины НЕ МОЖЕТ существовать.");