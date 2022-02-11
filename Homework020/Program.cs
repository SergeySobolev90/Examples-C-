//  Задача 20
//Задать номер четверти, показать диапазоны для возможных координат

int InPut(string message)
{
    Console.Write(message);
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

void Execute(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine();
    else if (x == 0 && y == 0)
        Console.WriteLine("Точка в начале координат");
    else
        Console.WriteLine("Точка вне четверти, она не в оси координат");

}

int x = InPut("Введите координату точки x для I четверти:");
int y = InPut("Введите координату точки y для I четверти:");

Execute(x, y);

Console.WriteLine("Диапозон для возможных координат: ");
for (int i = 0; i < x; i++)
    Console.WriteLine(i);

Console.WriteLine("Диапозон для возможных координат: ");
for (int i = 0; i < y; i++)
    Console.WriteLine(i);








