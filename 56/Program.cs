// Задача 56: Задайте двумерный массив. Напишите метод, 
// который будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк m: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов n: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

Console.WriteLine();

Console.WriteLine($"{FindRowWithMinSum(array)} строка");

int FindRowWithMinSum(int[,] array)
{
    int rowWithMinSum = 0;
    int minSum = array[0, 0]; ;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        minSum += array[0, k];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            rowWithMinSum = i;
        }
    }
    return rowWithMinSum + 1;
}

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}