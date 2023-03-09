// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 130);
    }
}

int NumbOfCut(int[] arr)
{
    int size = arr.Length;
    int numb = 0;
    for(int ind = 0; ind < size; ind++)
    {
        if(arr[ind] < 100 && arr[ind] > 9) numb = numb+1;
    }
    return numb;
}


int[] array = new int[123];

FillArray(array);
Console.WriteLine();
int result = NumbOfCut(array);
Console.WriteLine($"Количество чисел из отрезка = {result}");








// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }