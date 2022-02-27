// Задача 34 
// Написать программу замену элементов массива на противоположные

int[] arr = new int[10];

void FullArray()
{
    Random ran = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ran.Next(1, 10) - 5;
        Console.Write($"{arr[i]}  ");
    }

}

void ReplaceNum()
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -1 * arr[i];
        Console.Write($"{arr[i]}  ");
    }
}

FullArray();
Console.WriteLine();
ReplaceNum();