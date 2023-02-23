Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int last = number % 10;
Console.Write("Последняя цифра = ");
Console.WriteLine(last);