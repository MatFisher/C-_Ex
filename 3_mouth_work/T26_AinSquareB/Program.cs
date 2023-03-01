int Exponent(int numA, int numB)
{
    int index = 1;
    int numHelp = numA;
    while (index < numB)
    {
        numA = numA * numHelp;
        index++;
    }
    return numA;
}

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());

int exp = Exponent(numberA, numberB);
Console.WriteLine($"Результат = {exp}");
