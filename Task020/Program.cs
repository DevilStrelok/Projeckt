// Напишите программу, 
// которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = Math.Sqrt(5);
// double res = 5.099987564;
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);

Console.WriteLine("Ведите координаты точки");
Console.Write("Xa: ");
int xaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int yaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Xb: ");
int xbCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int ybCoordinate = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xaCoordinate, yaCoordinate, xbCoordinate, ybCoordinate);
double resRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками координат -> {resRound}");

double Distance(int xa, int ya, int xb, int yb)
{
    double x = (xa - xb);
    double y = (ya - yb);
    double distance = Math.Sqrt(x * x + y * y);
    return distance;
}
