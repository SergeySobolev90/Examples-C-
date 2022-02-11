// Задача 14 
// Найти третью цифру числа или сообщить, что ее нет 

Console.Write("Введите число: ");

string arbitraryNumberStr = Console.ReadLine();
if (int.TryParse(arbitraryNumberStr, out int arbitraryNumberInt))
{
    if (arbitraryNumberStr.Length >= 3)
        Console.WriteLine($"Третья цифра числа: {arbitraryNumberStr[2]}");
    else
        Console.WriteLine("Число не трехзначное.");
}
else
    Console.WriteLine("Ввели не число.");

