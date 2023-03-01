
void NaturArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index]=index+1;
        index++;
    }
}

// void PrintArray(int[] arr)
// {
//     int count = arr.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.WriteLine(arr[position]);
//         position++;
//     }
// }

void SquareArray(int[] ar)
{
    int longer = ar.Length;
    int pos = 0;
    while(pos < longer)
    {
        Console.Write($"{ar[pos]} = ");
        ar[pos] = ar[pos] * ar[pos];
        Console.WriteLine(ar[pos]);
        pos++;
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] m = new int[number];
NaturArray(m);
Console.WriteLine();
SquareArray(m);