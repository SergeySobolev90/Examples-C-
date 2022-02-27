// Задача 54 
// В матрице чисел найти сумму элементов главной диагонали


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

int Diagonal(int[,] arrSecond)
{
    int sum = 0;
    for (int i = 0; i < arrSecond.GetLength(0); i++)
    {
        for (int j = 0; j < arrSecond.GetLength(1); j++)
        {
            if (i == j)
                sum += arrSecond[i, j];
        }
    }
    return sum;
}

int[,] fillArr = FillArray();
PrintArray(fillArr);
Console.WriteLine();
Console.WriteLine($"Сумма диагонали = {Diagonal(fillArr)}");
