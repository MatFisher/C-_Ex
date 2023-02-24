Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
number = -number;
if (number >= 100 && number <= 999)
{
    int last = (number % 100)/10;
    Console.Write("Вторая цифра = ");
    Console.WriteLine(last);
}