void FillPrintArray(int[] collection)
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 20);
        Console.Write($" {collection[index]} ");
    }
}

void CompArray(int[] arr)
{
    int size = arr.Length;
    int temp = 0;
    Console.WriteLine("Произведения крайних элементов равны");
    for(int ind = 0; ind < size / 2; ind++)
    {
        temp = arr[ind] * arr[size - ind - 1];
        Console.Write($" {temp} ");
    }
}

int[] array = new int[10];
FillPrintArray(array);
Console.WriteLine();
CompArray(array);
Console.WriteLine();