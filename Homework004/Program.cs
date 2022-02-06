// Задача 4 
//Найти максимальное из трех чисел

int GetRandomNumber()
{
    int randomNumber = new Random().Next(0,100);
    return randomNumber;
}

int numOne = GetRandomNumber();
int numTwo = GetRandomNumber();
int numThree = GetRandomNumber();
int max = numOne;
if(numOne > max) max = numOne;
if(numTwo > max) max = numTwo;
if(numThree > max) max = numThree;

Console.WriteLine($"Максимальное из трех чисел: {max}");