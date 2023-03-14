// Задача 19
// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int reverse = 0;
int digital = 0;

while (number > 0)
{
    digital = number % 10;
    reverse = reverse * 10 + digital;
    number = number / 10;
}
if (temp == reverse)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
