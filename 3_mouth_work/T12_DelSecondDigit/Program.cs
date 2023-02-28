Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
number = -number;
if (number >= 100 && number <= 999)
{
    int last = (number % 100)/10;
    last = number - last*10;
    Console.Write("Число без второй цифры = ");
    Console.WriteLine(last);
}

//Второй вариант через функцию

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 -999 = {number}");

int DelDigit (int num) //
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

int delDigit = DelDigit(number);
Console.WriteLine($"Число без второй цифры = {delDigit}");