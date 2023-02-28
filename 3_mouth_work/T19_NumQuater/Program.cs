Console.WriteLine("Введите координату х, не равную 0");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y, не равную 0");
int numberB = Convert.ToInt32(Console.ReadLine());

void NumQuater(int x, int y)
{
    if(x > 0)
    {
        if(y > 0) Console.WriteLine("Точка в I четверти");
        else Console.WriteLine("Точка в IV четверти");
    }
    else 
    {
        if(y > 0) Console.WriteLine("Точка в II четверти");
        else Console.WriteLine("Точка в III четверти");
    }
}

NumQuater(numberA, numberB);