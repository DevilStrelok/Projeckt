// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int numberlast = number % 10;
    Console.WriteLine(numberlast);
}
else
{
    while (number > 99 && number < 1000)
    {
        number = number / 10;
    }
    Console.WriteLine("Третьей цифры нет");
}

//Не работает с 4х и более значными числами.
