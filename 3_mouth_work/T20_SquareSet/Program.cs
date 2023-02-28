Console.WriteLine("Введите номер четверти");
int numberA = Convert.ToInt32(Console.ReadLine());

void Plenty(int num)
{
    if(num > 0 && num < 5)
    {
        if(num == 1) Console.WriteLine("Координаты х > 0, координаты y > 0");
        if(num == 2) Console.WriteLine("Координаты х < 0, координаты y > 0");
        if(num == 3) Console.WriteLine("Координаты х < 0, координаты y < 0");
        if(num == 4) Console.WriteLine("Координаты х > 0, координаты y < 0");
    }
    else Console.WriteLine("Введите корректный номер четверти");
}

Plenty(numberA);