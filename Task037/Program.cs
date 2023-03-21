// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] Multiplication(int[] array)
{
    int size = array.Length % 2 > 0 ? (array.Length / 2) + 1 : array.Length / 2;
    int[] newArray = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {
        int number = array[i] * array[array.Length - 1 - i];
        newArray[i] = number;
    }

    if (array.Length % 2 > 0)
    {
        int indexMed = array.Length / 2;
        newArray[size - 1] = array[indexMed];
    }

    return newArray;
}

int[] array = CreateArrayRndInt(24, 3, 9);
PrintArray(array);
Console.WriteLine();
int[] newArr = Multiplication(array);
PrintArray(newArr);
