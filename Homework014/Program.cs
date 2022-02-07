// Задача 14 
// Найти третью цифру числа или сообщить, что ее нет 

int GetRandom()
{
    int number = new Random().Next(0, 1000);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число: {randomazer}");

int noThreeDigit = randomazer / 10;
int threeDigit = randomazer % 10;
if (noThreeDigit >= 10)
{
    Console.WriteLine($"Третья цифра числа: {threeDigit}");
}
else
{
    Console.WriteLine($"Третьей цифры нет ");
}
