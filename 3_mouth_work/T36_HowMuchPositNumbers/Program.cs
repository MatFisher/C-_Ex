void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int position = 0; position < count; position++)
    {
        Console.Write($" {col[position]} ");
    }
}

int SumEvenNumbers(int[] arr)
{
    int temp = arr.Length;
    int sumEven = 0;
    for(int pos = 0; pos < temp; pos++)
    {
        if(arr[pos] % 2 == 0) sumEven++;
    }
    return sumEven;
}

int SumOddNumbers(int[] ar)
{
    int temp2 = ar.Length;
    int sumOdd = 0;
    for(int p = 0; p < temp2; p++)
    {
        if(ar[p] % 2 == 1) sumOdd++;
    }
    return sumOdd;
}

int[] array = new int[10];

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int sum1 = SumEvenNumbers(array);
int sum2 = SumOddNumbers(array);
Console.WriteLine ($"Количество четных чисел = {sum1}");
Console.WriteLine ($"Количество нечетных чисел = {sum2}");
Console.WriteLine();