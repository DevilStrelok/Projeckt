// Напишите программу, 
// которая по заданному номеру четверти, 
// показывает диапазон возможных координат 
// точек в этой четверти (x и y).

Console.WriteLine("Ведите номер четверти: ");
Console.Write("number: ");
int number = Convert.ToInt32(Console.ReadLine());

string interval = Interval(number);
Console.WriteLine($"Указанная четверть соответствует координатам -> {interval}");

string Interval(int quarter)
{
    if (quarter == 1) return "x > 0 && y > 0";
    if (quarter == 2) return "x < 0 && y > 0";
    if (quarter == 3) return "x < 0 && y < 0";
    if (quarter == 4) return "x > 0 && y < 0";
    return "Такой четвери не существует";
}
