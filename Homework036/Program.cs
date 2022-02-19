// Задача 36 
//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int[] arr = new int[10];

void FullArray()
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"{arr[i]}");
    }
}

void Quantity()
{
    int even = 0;
    int odd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            even += arr[i];
        else
            odd += arr[i];
    }
    Console.WriteLine($"Количество четных чисел: {even}");
    Console.WriteLine($"Количество нечетных чисел: {odd}");
}

Console.Write("Одномерный массив: ");
FullArray();
Console.WriteLine();
Quantity();
