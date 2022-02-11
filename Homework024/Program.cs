//  Задача 24
// Найти кубы чисел от 1 до N

Console.Write("Введите целое число: ");
int randomNumber = int.Parse(Console.ReadLine());

for (int i = 0; i <= randomNumber; i++)
    Console.Write($"{i * i * i} ");

