﻿Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int HowManyDigit(int num)
{
    int index = 0;
    while(num % 10 > 0) 
    {
        index = index + 1;
        num = num / 10;
    }
    return index;
}

int size = HowManyDigit(number);
Console.WriteLine($"Количество цифр в числе = {size}");