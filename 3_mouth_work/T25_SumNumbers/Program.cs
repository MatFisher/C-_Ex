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

void SumA(int[] ar)
{
    int longer = ar.Length;
    int pos = 0;
    int sum = 0;
    while(pos < longer)
    {
        sum = ar[pos] + sum;
        pos++;
    }
    Console.WriteLine($"Сумма чисел ряда = {sum}");
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] m = new int[number];
NaturArray(m);
SumA(m);