// Задача 28
// Посчитать сумму цифр в числе


int DigitsSum(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр: " + DigitsSum(n));

