// Задача 40 
// В Указанном массиве вещественных чисел 
//найдите разницу между максимальным и минимальным элементом

double[] arr = new double[10];

void FullArray()
{
    Random ran = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ran.NextDouble() * 100;
        Console.Write("{0,6:F2}", arr[i]);
    }
}

void Difference()
{
    double max = 0;
    double min = arr[0];
    double diff = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
            max = arr[i];
        if (min > arr[i])
            min = arr[i];
    }
    diff = max - min;
    Console.WriteLine($"Разница между max {max:F2} и min {min:F2} = {diff:F2}");
}

FullArray();
Console.WriteLine();
Difference();