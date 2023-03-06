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