// 11. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Закомментированы другие варианты решения

Console.WriteLine("Чтобы выйти введите -1");
Console.Write("Введите число: ");
string stringNum = Console.ReadLine()??"0";
int num = Convert.ToInt32(stringNum);

if (stringNum.Length != 3)
    Console.WriteLine("Число не трёхзначное");
else
{
    Console.WriteLine((num / 100) * 10 + (num % 10));
}

// Console.WriteLine(stringNum.Length != 3 ? "Число не трёхзначное" : (num / 100) * 10 + (num % 10));

Console.WriteLine();

