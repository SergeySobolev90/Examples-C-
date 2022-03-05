// Задача 69
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 15
// M = 4; N = 8. -> 5

int m = 1;
int n = 5;

int RecursionSumm(int m, int n)
{
    int sum = m;
    if(m < n)
    {
        sum+= RecursionSumm(m + 1, n);
    }
    return sum;
}

Console.WriteLine($"Задано М = {m}, и N = {n}");
Console.WriteLine();
Console.WriteLine(RecursionSumm(m, n));
