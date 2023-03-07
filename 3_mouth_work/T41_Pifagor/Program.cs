Console.WriteLine("Введите сторону А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C");
int numC = Convert.ToInt32(Console.ReadLine());

string Pifagor(int a, int b, int c)
{
    double temp = Math.Sqrt(a*a+b*b);
    string res;
    if(c == temp) res = "true";
    else res = "false";
    return res ;
}   

string result = Pifagor(numA, numB, numC);
Console.WriteLine(result);