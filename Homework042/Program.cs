// Задача 42 
// Определить сколько чисел больше 0 введено с клавиатуры

int numbers = 5;
int count = 0;
while (numbers > 0)
{
    Console.Write("Введите число: ");
    string valueStr = Console.ReadLine();
    if (int.TryParse(valueStr, out int valueInt))
    {
        if (valueInt > 0)
        {
            count++;
        }
        numbers--;
    }
}
Console.WriteLine($"Количество чисел больше 0, введенных с клавиатуры = {count}");







