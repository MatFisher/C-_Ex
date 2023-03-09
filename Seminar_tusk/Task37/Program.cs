﻿//  Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
 
int[] CreateArrayRndInt(int size, int min, int max)
{
     int[] arr = new int[size];
     Random rnd = new Random();
     for (int i = 0; i < size; i++)
     {
         arr[i] = rnd.Next(min, max + 1);
     }
     return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] CompArray(int[] arr)
{
    int size = arr.Length;
    int[] temp = size % 2 == 0 ? new int[size / 2] : new int[(size / 2) + 1];
    for (int ind = 0; ind < temp.Length; ind++)
    {
        if(ind != size - ind - 1) temp[ind] = arr[ind] * arr[size - ind - 1];
        else temp[ind] = arr[ind];                         
    }
    return temp;
}

int[] array = CreateArrayRndInt(10, 0, 9);
PrintArray(array);
int[] result = CompArray(array);
PrintArray(result);

