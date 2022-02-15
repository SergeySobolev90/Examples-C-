// Задача 30 
// Показать кубы чисел, заканчивающихся на четную цифру

int randomNumber = new Random().Next(1, 100);

for (int i = 1; i <= randomNumber; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i * i * i} ");
    }
}

