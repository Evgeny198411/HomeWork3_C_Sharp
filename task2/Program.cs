/*
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void distance3d (double[] p1, double[] p2)
{
    double distance = Math.Sqrt(Math.Pow(p1[0] - p2[0], 2) + Math.Pow(p1[1] - p2[1], 2) + Math.Pow(p1[2] - p2[2], 2));
    Console.WriteLine(distance);
}

double[] coordinates()
{
    double[] point = new double[3];
    for (int i= 0; i < 3; i++)
    {
        Console.WriteLine($"введите {i + 1} координату ");
        point[i] = double.Parse(Console.ReadLine());
    }
    return point;
}

double[] point1 = coordinates();
double[] point2 = coordinates();

distance3d(point1, point2);