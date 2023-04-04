// Задача 67: 
// Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {sumNumber}");

int SumNumber(int num)
{
    if (num == 0) return 0;
    else return SumNumber(num / 10) + num % 10;
}
