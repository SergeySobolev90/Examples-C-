// Задача 32
// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8];
Console.WriteLine("Массив из 8 элементов:");

Random ran = new Random();
for (int i = 0; i < 8; i++)
{
    array[i] = ran.Next(0, 2);
    Console.Write($"{array[i]}");
}
