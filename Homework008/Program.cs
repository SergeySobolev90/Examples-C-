// Задача 8
// Показать четные числа от 1 до N

Console.Write("Введите число N: ");
string userNumber = Console.ReadLine();
int number = int.Parse(userNumber);

for (int initialNum = 2; initialNum < number; initialNum++)
{
    if (initialNum % 2 == 0)
    {
        Console.Write(initialNum + " ");
    }
}
