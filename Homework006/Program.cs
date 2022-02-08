// Задача 6 
//Выяснить является ли число чётным

Console.Write("Введите любое целое число: ");
string valueStr = Console.ReadLine();
if(int.TryParse(valueStr, out int valueInt))
{
    if (valueInt % 2 == 0)
    Console.WriteLine($"{valueStr} четное число.");
    else
    Console.WriteLine($"{valueStr} не четное число.");
}

