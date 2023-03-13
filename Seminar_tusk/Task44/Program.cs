Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n - 2);
}

Fibonacci(number);
Console.Write("0");
for(int i = 1; i < number; i++)
{
    Console.Write(Fibonacci(i));
}

// Вариант 2

// int[] Fibbonah(int number)
// {
//     int[] array = new int[number];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < number; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];

//     }
//     return array;
// }
// void PrintArray(int[] col)
// {

//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }
// }

// Console.WriteLine("Введите число N:");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arr = Fibbonah(num);
// Console.Write($"Если N = {num} -> ");
// PrintArray(arr);