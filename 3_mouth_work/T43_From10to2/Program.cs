Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int TenToTwo(int number)
{
    int number2 = number;
    int index = 0;
    for(index = 0; number2 > 1; index++) //Узнаю сколько разрядов будет в числе в 2 системе
    {
        number2 = number2 / 2;
    }
    int size = index+1;
    int[] array = new int [size];
    for(index = 0; index < size; index++) //Получаю обратное число в 2 системе в виде массива
    {
        array[index] = number % 2;
        number = number / 2;
    }
    int temp = 0;
    for(index = 0; index < size / 2; index++)//Перевочиваю число, чтобы получить правильный порядок цифр
    {
        temp = array[index];
        array[index] = array[size-index-1];
        array[size-index-1] = temp;
    }
    string res = String.Concat(array); // Преобразую массив в строку
    int result = Convert.ToInt32(res); // Преобразую массив в число
    return result;
}

int arr = TenToTwo(num);
Console.WriteLine($"Число в двоичной системе = {arr}");