// Задача 40: 
// Напишите программу, 
// которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();

Console.Write("Введите длину строны 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину строны 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину строны 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(number1, number2, number3);
Console.WriteLine(result ? "Существует" : "Не существует");

bool IsExistTriangle(int n1, int n2, int n3)
{
    return n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2;
}
