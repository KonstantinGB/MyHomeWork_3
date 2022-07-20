/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

double Rastoyanie (int x1, int y1,int z1, int x2, int y2, int z2)
{
    double ac = z2 - z1;
    double cb1 = x2 - x1;
    double ab1 = Math.Sqrt (ac * ac + cb1 * cb1);
    double bb1 = y2 - y1;
    double distance = Math.Sqrt( ab1 * ab1 + bb1 * bb1);
    return distance;
}

Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dis = Rastoyanie(x1, y1, z1, x2, y2, z2);
Console.Write("Расстояние между точками: " + dis);