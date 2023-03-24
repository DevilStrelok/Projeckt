// Задача 45: 
// Напишите программу, 
// которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

Console.Clear();

int[] myArray = CreateArrayRndInt(10, 1, 10);
int[] newArr = CopyArray(myArray);

Console.WriteLine("\nИсходный массив"); //Console.WriteLine() = \n
PrintArray(myArray);

Console.WriteLine("Новый массив");
PrintArray(newArr);

bool res = Equal(myArray, newArr);
Console.WriteLine(res ? "Равны" : "Не равны");

bool Equal(int[] arr1, int[] arr2)
{
    if (arr1.Length != arr2.Length)
    {
        return false;
    }

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] != arr2[i])
        {
            return false;
        }
    }
    return true;
}

int[] CopyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}

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
    Console.WriteLine("{0}", string.Join(" ", arr));
    Console.WriteLine();
}
