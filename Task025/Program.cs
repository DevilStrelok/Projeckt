// Задача 25: 
// Напишите цикл, 
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumder(number, degree);
Console.WriteLine($"Число {number} в степени {degree} -> {degreeNumber}");

int DegreeNumder(int num, int deg)
{
    int result = 1;
    for (int count = 1; count <= deg; count++)
    {
        result = result * num;
    }
    return result;

}
