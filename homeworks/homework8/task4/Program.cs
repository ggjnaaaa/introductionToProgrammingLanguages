// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Заполняет массив случайными разными числами
void DifferentIntRandom3DArray(int[,,] array, int minElement, int maxElement)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int rand;
                bool isDiff = false;
                // Проверка на совпадение рандомного числа с числами в массиве
                do 
                {
                    rand = rnd.Next(minElement, maxElement + 1);

                    foreach (int element in array)
                    {
                        if (rand == element)
                            break;
                        else
                            isDiff = true;
                    }
                } while(!isDiff);

                array[i, j, k] = rand;
            }
}
// Выводит элементы массива в консоль
void Output3DArray(int[,,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");

            Console.WriteLine();
        }
    }
}

// Границы рандомного заполнения массива
int minElement = 10;
int maxElement = 99;

// Создание и вывод массива
int[,,] array = new int[5, 3, 6];
DifferentIntRandom3DArray(array, minElement, maxElement);
Output3DArray(array, "Mассив: ");

