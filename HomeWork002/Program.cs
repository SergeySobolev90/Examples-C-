//  Задача 2 
// Даны два числа. Показать большее и меньшее число.

int GetRandomNumber()
{
    int randomNumber = new Random().Next(0, 100);
    return randomNumber;
}

int firstNumber = GetRandomNumber();
int secondNumber = GetRandomNumber();

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Большее число: {firstNumber} Меньшее число: {secondNumber}");
}
else
{
    Console.WriteLine($"Большее число: {secondNumber} Меньшее число: {firstNumber}");
}


