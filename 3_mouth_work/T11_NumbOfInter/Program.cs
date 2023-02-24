Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10 && number <=99)
{ 
    int last = (number % 100)/10;
    int first = (number % 10);
    if (first>last){
    Console.Write("Наибольшая цифра числа = ");
    Console.WriteLine(first);
}
else {Console.Write("Наибольшая цифра числа = ");
    Console.WriteLine(last);
}
}
else Console.WriteLine("Заданное число не входит в отрезок");
