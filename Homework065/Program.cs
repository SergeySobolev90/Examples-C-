//  Задача 65 
// Спирально заполнить двумерный массив

int[,] FillArray()
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}

void SpiralArray(int[,] array)
{
    int i = 0;
    int j = 0;
    int num = 1;
    while (j < array.GetLength(1) - 1)
    {
        array[i, j] = num;
        num++;
        j++;
    }
    while (i < array.GetLength(0) - 1)
    {
        array[i, j] = num;
        num++;
        i++;
    }
    while (j > 0)
    {
        array[i, j] = num;
        num++;
        j--;
    }
    while (i > 0)
    {
        array[i, j] = num;
        num++;
        i--;
    }
    i++;
    j++;
    while (j < array.GetLength(1) - 1)
    {
        array[i, j] = num;
        num++;
        j++;
    }
    while (j > 1)
    {
        array[i + 1, j - 1] = num;
        num++;
        j--;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"  {array[i, j]} ");
            else
                Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] arr = FillArray();
PrintArray(arr);
Console.WriteLine();
SpiralArray(arr);
Console.WriteLine("Заполнен по спирали:");
PrintArray(arr);