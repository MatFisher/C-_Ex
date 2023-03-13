// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите сторону А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C");
int numC = Convert.ToInt32(Console.ReadLine());

bool Pifagor(int a, int b, int c)
{
    double temp = Math.Sqrt(a*a+b*b);
    if(c == temp) return true;
    else return false;
}   

string result = Pifagor(numA, numB, numC);
Console.WriteLine(result);