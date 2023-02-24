Console.WriteLine("Введите большее число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для проверки");
int numB = Convert.ToInt32(Console.ReadLine());

int last = numA % numB;
if(last==0)
{
    Console.Write("Число делится без остатка");
}
else 
{
    Console.Write("Остаток от деления равен = ");
    Console.WriteLine(last);
}