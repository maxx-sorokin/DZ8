// Задача 58: Задайте две матрицы. Напишите метод,
// который будет находить произведение двух матриц.

Console.Write("Введите количество строк m: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов n: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array1 = CreateRandom2DArray(m, n);
Print2DArray(array1);

Console.WriteLine();

int[,] array2 = CreateRandom2DArray(m, n);
Print2DArray(array2);

Console.WriteLine();

int[,] multiplicationArray = Multiplication2DArray(array1, array2);
Print2DArray(multiplicationArray);

int[,] Multiplication2DArray(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(1); k++)
            {
                newArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return newArray;
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