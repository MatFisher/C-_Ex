// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber(int[] ar, int num)
{
    for (int i = 0; i < ar.Length; i++)
    {
        if(ar[i] == num) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(10, 0, 10);
PrintArray(array);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string output = FindNumber(array, number) ? "Yes" : "No";
Console.WriteLine(output);