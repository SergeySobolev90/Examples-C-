// Задача 44 
// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 и k1 и b2 и k2 заданы


double InPut(string message)
{
    Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double k1 = InPut("Введите k1:");
double b1 = InPut("Введите b1:");
double k2 = InPut("Введите k2:");
double b2 = InPut("Введите b2:");

if (k1 == k2)
    Console.WriteLine("Премые параллельны.");

double x = (b2 - b1) / (k1 - k2);
Console.WriteLine($"Точка пересечения: {x}");
