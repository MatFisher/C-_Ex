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

void Factorial(int[] ar)
{
    int longer = ar.Length;
    int pos = 0;
    int fact = 1;
    while(pos < longer)
    {
        fact = fact * ar[pos];
        pos++;
    }
    Console.WriteLine($"Факториал числа = {fact}");
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] m = new int[number];
NaturArray(m);
Factorial(m);