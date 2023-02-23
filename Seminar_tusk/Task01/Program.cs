double numA, numB;
Console.WriteLine("Введите большее целое число");
numA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число для проверки");
numB = double.Parse(Console.ReadLine());
double index = 1;
if(index==numA/(numB*numB))
{
    Console.WriteLine("Квадратом является");
}
else
{
    Console.WriteLine("Квадратом не является");
}
