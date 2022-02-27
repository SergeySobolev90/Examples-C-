// Задача 38
// Найти сумму чисел одномерного массива стоящих на нечетной позиции


int[] arr = new int[20];

void FullArray()
{
    Random ran = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ran.Next(1, 9);
        Console.Write($"{arr[i]} ");
    }

}

void Summ()
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum += arr[i];
    }
    Console.WriteLine($"Cумма чисел стоящих на нечетной позиции: {sum}");
}

Console.Write("Одномерный массив: ");
FullArray();
Console.WriteLine();
Summ();