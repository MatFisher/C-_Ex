Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int last = (number % 1000)/100;
if (last==0) Console.Write("Цифра отсутствует");
else 
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(last);
}