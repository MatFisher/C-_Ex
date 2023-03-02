// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double res = Math.Sqrt(5);
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);

// Math.Sqrt(5);
// double res = 5.09987564;
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

// Console.WriteLine(resRound);

Console.WriteLine("Введите координату х первой точки");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int numY2 = Convert.ToInt32(Console.ReadLine());

double Distance (int xOne, int yOne, int xTwo, int yTwo)
{
    int x = xOne - xTwo;
    int y = yOne - yTwo;
    double dist = Math.Sqrt(x*x + y*y);
    return dist;
}

double result = Distance (numX1, numY1, numX2, numY2);
result = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(result);

//Решение 2 вариант

// Console.WriteLine("Введите координаты первой точки");
// Console.Write("X: ");
// int xPointA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yPointA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки");
// Console.Write("X: ");
// int xPointB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yPointB = Convert.ToInt32(Console.ReadLine());
// double distance = Distance(xPointA, yPointA, xPointB, yPointB);
// Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2, MidpointRounding.ToZero)}");

// double Distance(int xA, int yA, int xB, int yB)
// {
//     return Math.Sqrt(Math.Pow(xA-xB, 2)+Math.Pow(yA-yB, 2));
// }