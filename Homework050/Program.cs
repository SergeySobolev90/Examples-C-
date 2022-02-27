// Задача 50 
// В двумерном массиве n×k заменить четные элементы на противоположные



Random rand = new Random();
int[,] FillArray()
{
    int[,] arr = new int[5, 5];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] Replace(int[,] arrSecond)
{
    for (int i = 0; i < arrSecond.GetLength(0); i++)
    {
        for (int j = 0; j < arrSecond.GetLength(1); j++)
        {
            if (arrSecond[i, j] % 2 == 0)
                arrSecond[i, j] *= -1;
        }
    }
    return arrSecond;
}

int[,] fillArr = FillArray();
PrintArray(fillArr);
Console.WriteLine();
int[,] RepMat = Replace(fillArr);
PrintArray(RepMat);




