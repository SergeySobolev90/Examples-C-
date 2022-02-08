// 10 Задача
// Показать вторую цифру трехзначного числа

/*int GetRandom()
{
    int number = new Random().Next(100, 1000);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число {randomazer}");

int result = randomazer % 100 / 10;
Console.WriteLine($" Вторая цифра трехзначного числа:  {result}"); */


Console.Write("Введите трехзначное число: ");

 string threeDigitNumStr = Console.ReadLine();
 if(int.TryParse(threeDigitNumStr, out int threeDigitNumInt))
 {
     if(threeDigitNumStr.Length >= 3)
    {
        Console.WriteLine($"Вторая цифра числа: {threeDigitNumStr[1]}");
    }
     else
     {
         Console.WriteLine("Число не трехзначное.");
     }
 }
  else
  {
      Console.WriteLine("Ввели не число.");
  }