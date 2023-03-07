// 1. Напишите программу
// 2.которая на вход принимает два числа
// 3. и проверяет, является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.Write("Введите целое число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}