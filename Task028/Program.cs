// Напишите программу, 
// которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int productNumbers = ProductNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {productNumbers}");

int ProductNumbers(int num)
{
    int product = 1;
    for (int count = 2; count <= num; count++)
    {
        checked
        {
            product = product * count;
        }
    }
    return product;
}
