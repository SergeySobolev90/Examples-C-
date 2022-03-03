// Задача 59
// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Random rand = new Random();
int[,] FillArray()
{
    int[,] array = new int[4, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortingArray(int[,] array)
{
    int result = 0;
    int raw = 1;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0)
        {
            result = sum;
        }
        else
        {
            if (sum < result)
            {
                result = sum;
                raw = i + 1;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {raw}");
}
int[,] twoArray = FillArray();
Console.WriteLine();
PrintArray(twoArray);
Console.WriteLine();
SortingArray(twoArray);