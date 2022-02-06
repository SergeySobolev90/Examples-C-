// Задача 6 
//Выяснить является ли число чётным

Console.Write("Введите любое целое число: ");
string userNumber = Console.ReadLine();
double numDouble = int.Parse(userNumber);
if (numDouble % 2 == 0)
{
    Console.WriteLine($"{numDouble} четное число.");
}
else
{
    Console.WriteLine($"{numDouble} не четное число.");
}

