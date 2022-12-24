// Напишите программу, которая 
// принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А(x,y,z)");
Console.Write("A(x): ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("A(y): ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("A(z): ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B(x,y,z): ");
Console.Write("B(x): ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("B(y): ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("B(z): ");
int zb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa, xb, ya, yb, za, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками А({xa},{ya},{za}) и B({xb},{yb},{zb}) = {ourDistance}.");


double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));
    return distance;
}