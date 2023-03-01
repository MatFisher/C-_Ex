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

void SumElements(int[] array)
{
    int size = array.Length;
    int ind = 0;
    int sumPlus = 0;
    int sumMinus = 0;
    while(ind < size)
    {
        if(array[ind] < 0) sumMinus = sumMinus + array[ind];
        else sumPlus = sumPlus + array [ind];
        ind++;
    }
    Console.WriteLine($"Сумма положительных элементов = {sumPlus}");
    Console.WriteLine($"Сумма отрицательных элементов = {sumMinus}");
}

int[] m = new int[12];

FillArray(m);
Console.WriteLine();
PrintArray(m);
Console.WriteLine();
Console.WriteLine();
SumElements(m);
Console.WriteLine();