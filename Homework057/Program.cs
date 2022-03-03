// Задача 57
//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Random rand = new Random();
int[,] FillArray()
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(10, 100);
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
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SortingArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int position = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, position])
                {
                    position = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = array[i, position];
            array[i, position] = temp;
        }
    }
    return array;
}
int[,] twoArray = FillArray();
Console.WriteLine();
PrintArray(twoArray);
int[,] newTwoArray = SortingArray(twoArray);
Console.WriteLine();
PrintArray(newTwoArray);