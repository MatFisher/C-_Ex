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
    while (position < count)
    {
        Console.Write($" {col[position]} ");
        position++;
    }
}

void FindOf(int[] arr, int find)
{
    int coun = arr.Length;
    int index = 0;
    while (index < coun)
    {
        if (arr[index] == find)
        {
            Console.WriteLine("Число присутствует");
            break;
        }
        index++;
    }
}

int[] m = new int[12];

FillArray(m);
Console.WriteLine();
PrintArray(m);
Console.WriteLine();
Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
FindOf(m, number);
