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

//Решение от препода

Console.WriteLine("Введите координату х");
int numbA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int numbB = Convert.ToInt32(Console.ReadLine());

int Quarter (int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
int quat = Quarter(numbA, numbB);
string result = quat > 0 
                ? "$Указанные координаты соответствуют четверти {quat}" 
                : "ВВедены некорректные координаты";
Console.WriteLine(result);