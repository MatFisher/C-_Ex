Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    int index = 1;
    int result = 0;
    while(index <= num)
    {
        Console.Write($"{index} = ");
        result = index*index;
        Console.WriteLine(result);
        index++;
    }
}

Square(number);