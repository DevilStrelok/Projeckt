// Задача 21
// Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Ведите координаты точки");

Console.Write("Xa: ");
int xaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int yaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Za: ");
int zaCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Xb: ");
int xbCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int ybCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb: ");
int zbCoordinate = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xaCoordinate, yaCoordinate, zaCoordinate,
                           xbCoordinate, ybCoordinate, zbCoordinate);
double resRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками координат -> {resRound}");

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double x = (xa - xb);
    double y = (ya - yb);
    double z = (za - zb);
    double distance = Math.Sqrt(x * x + y * y + z * z);
    return distance;
}
