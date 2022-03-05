// Задача 71
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int m = 3;
int n = 2;

int AckermanRec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (n == 0)
    {
        return AckermanRec(m - 1, 1);
    }
    else
    {
        return AckermanRec(m - 1, AckermanRec(m, n - 1));
    }

}

Console.WriteLine($"Задано М = {m}, и N = {n}");
Console.Write($"Вывод результата:");
Console.WriteLine(AckermanRec(m, n));
