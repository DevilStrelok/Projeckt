// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine($"Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int nuturalNumberSum = NuturalNumberSum(numberM, numberN);
Console.WriteLine(nuturalNumberSum);

int NuturalNumberSum(int numM, int numN)
{
    if (numM < numN)
    {
        return numM + NuturalNumberSum(numM + 1, numN);
    }
    else if (numM > numN)
    {
        return numM + NuturalNumberSum(numM - 1, numN);
    }
    else return numM;
}
