// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите число 1: ");
// double number1 = Convert.ToInt64(Console.ReadLine());
// Console.Write("Введите число 2: ");
// double number2 = Convert.ToInt64(Console.ReadLine());
// int result = 0;

// if (result = number1 % number2 == 0)
// {
//     Console.WriteLine("Кратное");
// }
// else
// {
//     Console.WriteLine("Не кратно, остаток "+result+"");
// }

//////////////////////////////////////////////////////////////////////////////////

// Console.WriteLine(remainder == 0 ? "кратно" : $"не кратно, остаток {remainder}" );

//////////////////////////////////////////////////////////////////////////////////

Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = ReadConsole();

Console.Write("Введите второе число: ");
int secondNumber = ReadConsole();

int result = IsMultiplicity(firstNumber, secondNumber) ;

if(result == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {result}");
}

int IsMultiplicity(int number1, int number2)
{
    return number1 % number2;
}

int ReadConsole()
{
    var str = Console.ReadLine();
    int number = Convert.ToInt32(str);
    return number;
}
