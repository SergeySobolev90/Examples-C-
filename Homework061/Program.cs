// Задача 61
// Найти произведение двух матриц

Random rand = new Random();
int[,] FillArray()
{
    int[,] array = new int[4, 4];
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
int[,] MultipleArray(int[,] firstArray, int[,] secondArray)
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(0); j++)
        {
            for (int k = 0; k < secondArray.GetLength(1); k++)
            {
                array[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return array;
}
int[,] firstArray = FillArray();
Console.WriteLine("Первый массив:");
PrintArray(firstArray);
int[,] secondArray = FillArray();
Console.WriteLine("Второй массив:");
PrintArray(secondArray);
int[,] multiple = MultipleArray(firstArray, secondArray);
Console.WriteLine("Произведение:");
PrintArray(multiple);
