Console.WriteLine("Введите пятизначное число");
int numberA = Convert.ToInt32(Console.ReadLine());

void Palindrom(int num)
{
    if(num % 100000 / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10) Console.WriteLine("Palindrom");
    else Console.WriteLine("Not palindrom");
}

Palindrom(numberA);