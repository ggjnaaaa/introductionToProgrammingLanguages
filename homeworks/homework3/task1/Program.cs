// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Сделать через словарь 

// Вывод сообщения и запись полученного числа
bool Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    if (number < 10000 || number > 99999) 
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }

    Dictionary<int, int> numberDictionary = NumberToDictionary(number);

    return CheckingPalindrome(numberDictionary);
}

// Запись цифр числа в словарь в обратном порядке
Dictionary<int,int> NumberToDictionary(int number)
{
    Dictionary<int, int> nums = new Dictionary<int, int>();
    for (int i = 5; i >= 1; i--)
    {
        nums.Add(i, number % 10);
        number = number / 10;
    }

    return nums;
}

// Проверяет, является ли число палиндромом
bool CheckingPalindrome(Dictionary<int, int> numberDictionary)
{
    if (numberDictionary[5] == numberDictionary[1] && numberDictionary[4] == numberDictionary[2])
        return true;
    else return false;
}

Console.WriteLine(Prompt("Введите число: "));
