void FillPrintArray(int[] collection)
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 20);
        Console.Write($" {collection[index]} ");
    }
}

int SumOddNumbers(int[] arr)
{
    int size = arr.Length;
    int sum = 0;
    for(int ind = 0; ind < size; ind++)
    {
        if(ind % 2 == 0); 
        else sum = sum + arr[ind];
    }
    return sum;
}

int[] array = new int[10];

FillPrintArray(array);
Console.WriteLine();
int result = SumOddNumbers(array);
Console.WriteLine($"Сумма всех элементов на нечетной позиции = {result}");