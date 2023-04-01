// Задача 59: 
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

int[,] FindPositionSmallElement(int[,] matrix, int[,] position)
{
    int temp = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= temp)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                temp = matrix[i, j];
            }
        }
    }
    Console.WriteLine($"Mинимальный элемент: {temp}");
    return position;
}

void DeleteLines(int[,] matrix, int[,] positionSmallElement, int[,] arrayWithoutLines)
{
    int k = 0, l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
            {
                arrayWithoutLines[k, l] = matrix[i, j];
                l++;
            }
        }
        l = 0;
        if (positionSmallElement[0, 0] != i)
        {
            k++;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);

int[,] positionSmallElement = new int[1, 2];
positionSmallElement = FindPositionSmallElement(array2d, positionSmallElement);
Console.Write($"Позиция элемента: ");
Console.WriteLine();
PrintMatrix(positionSmallElement);

int[,] arrayWithoutLines = new int[array2d.GetLength(0) - 1, array2d.GetLength(1) - 1];
DeleteLines(array2d, positionSmallElement, arrayWithoutLines);
Console.WriteLine($"Получившийся массив:");
PrintMatrix(arrayWithoutLines);
