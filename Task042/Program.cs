// Задача 42: 
// Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

Console.Write("Введите десятичное число: ");
int decimal1 = Convert.ToInt32(Console.ReadLine());

string resultStr = DecToBinString(decimal1);
Console.WriteLine($"{resultStr} через метод string");

int resultInt = DecToBinInt(decimal1);
Console.WriteLine($"{resultInt} через метод int");

string DecToBinString(int decimalNumber)
{
    if (decimalNumber == 0 || decimalNumber == 1)
    {
        return decimalNumber.ToString();
    }

    string dec = string.Empty;
    while (decimalNumber > 0)
    {
        dec = decimalNumber % 2 + dec;
        decimalNumber /= 2;
    }
    return dec;
}

int DecToBinInt(int decimalNumber)
{
    if (decimalNumber == 0 || decimalNumber == 1)
    {
        return decimalNumber;
    }

    int dec = 0;
    int i = 1;
    while (decimalNumber > 0)
    {
        dec = dec + decimalNumber % 2 * i;
        decimalNumber /= 2;
        i *= 10;
    }
    return dec;
}
