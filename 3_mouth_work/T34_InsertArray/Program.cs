void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($" {col[position]} ");
        position++;
    }
}

void InsertElements(int[] array)
{
    int size = array.Length;
    int ind = 0;
    while(ind < size)
    {
        array[ind] = -array[ind];
        ind++;
    }
}

int[] m = new int[12];

FillArray(m);
Console.WriteLine();
PrintArray(m);
Console.WriteLine();
InsertElements(m);
Console.WriteLine();
PrintArray(m);
Console.WriteLine();
