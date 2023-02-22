double numA, numB, numC;
Console.WriteLine("Введите первое число");
numA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
numB = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
numC = double.Parse(Console.ReadLine());
double max=numA;

if(max < numB) max = numB;
if(max < numC) max = numC;

Console.Write("Максимальное число = ");
Console.WriteLine(max);