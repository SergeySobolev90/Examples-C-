// 10 Задача
// Показать вторую цифру трехзначного числа

int GetRandom()
{
    int number = new Random().Next(100, 1000);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число {randomazer}");

int result = randomazer % 100 / 10;
Console.WriteLine($" Вторая цифра трехзначного числа:  {result}");