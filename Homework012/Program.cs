// Задача 12 
// Удалить вторую цифру трехзначного числа 

int GetRandom()
{
    int number = new Random().Next(100, 1000);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число: {randomazer}");

int firstDigit = randomazer / 100;
int lastDigit = randomazer % 10;
Console.WriteLine($"{firstDigit}{lastDigit}");