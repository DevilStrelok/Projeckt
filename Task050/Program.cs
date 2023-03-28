// Задача 50. 
// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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
}

void CheckMatrixIndex(int[,] matrix, int indexRow, int indexColumn)
{
    if (indexRow < 0 | indexRow > matrix.GetLength(0) - 1 | indexColumn < 0 | indexColumn > matrix.GetLength(1) - 1)
    {
        Console.WriteLine("Такой позиции не существует");
    }
    else
    {
        Console.WriteLine(matrix[indexRow, indexColumn]);
    }
}

Console.Write("Введите индекс строки: ");
int indexRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int indexColumn = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();

CheckMatrixIndex(array2d, indexRow, indexColumn);
