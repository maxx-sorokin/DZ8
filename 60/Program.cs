// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Введите первое измерение m: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите второе измерение n: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите третье измерение l: ");
bool isParsedL = int.TryParse(Console.ReadLine(), out int l);

if (!isParsedM || !isParsedN || !isParsedL)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,,] array = CreateRandom3DArray(m, n, l);
Print3DArray(array);

Console.WriteLine();

int[,,] CreateRandom3DArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number = random.Next(10, 100);
                while (Contains(number, array))
                {
                    number = random.Next(10, 100);
                }
                array[i, j, k] = number;
            }
        }
    }
    return array;
}

bool Contains(int number, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (number == array[i, j, k])
                {
                    return true;
                }
            }

        }
    }
    return false;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}