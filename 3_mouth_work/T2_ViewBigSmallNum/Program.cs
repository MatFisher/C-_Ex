double numA, numB;
Console.WriteLine("Введите первое число");
numA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
numB = double.Parse(Console.ReadLine());
if(numA>numB)
{
    Console.Write("Большее число = ");
    Console.WriteLine(numA);
    Console.Write("Меньшее число = ");
    Console.Write(numB);
}
else
{
    Console.Write("Большее число = ");
    Console.WriteLine(numB);
    Console.Write("Меньшее число = ");
    Console.Write(numA);
}
