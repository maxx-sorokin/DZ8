// Задача 62. Напишите метод, который заполнит спирально массив 4 на 4.

Console.Write("Введите количество строк m: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов n: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateSpiral2DArray(m, n);
Print2DArray(array);

int[,] CreateSpiral2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    int row = 0;
    int column = 0;

    for (int i = 1; i <= array.Length; i++)
    {
        array[row, column] = i;
        column++;

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