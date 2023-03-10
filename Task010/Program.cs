// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int secondDigit = (number - (firstDigit * 100 + thirdDigit)) / 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Введите ТРЁХзначное число: ");
}

// int finalresult = RemuveDigit(number);
// int RemuveDigit(int num)
// {
//     int firstDigit = number / 100;
//     int thirdDigit = number % 10;
//     int secondDigit = (number - (firstDigit * 100 + thirdDigit))/10;
//     return secondDigit;
// }
// Console.WriteLine(finalresult);
