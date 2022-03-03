// Задача 63 
// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента

Random rand = new Random();
int[,,] FillArray()
{
    int[,,] array = new int[3, 3, 3];
    rand.Next(10, 20);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand.Next(10, 20);

            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] = {array[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] arr = FillArray();
Console.WriteLine();
PrintArray(arr);


