int Mod(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}
void PrintMod(int remain)
{
    if (remain == 0)
        Console.WriteLine("Число кратно");
    else
        Console.WriteLine($"Не кратно, остаток {remain}");
}
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int mod = Mod(number1, number2);
PrintMod(mod);

//Второй вариант решения

Console.WriteLine("Введите первое число:");
int numbe1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Второе число:");
int numbe2 = Convert.ToInt32(Console.ReadLine());

int remainsDigits = RemainsDigits(numbe1, numbe2);

Console.WriteLine(remainsDigits == 0 ? "Кратно" : $"Не кратно, остаток -> {remainsDigits}");

int RemainsDigits(int num1, int num2)
{
    return num1 % num2;
}