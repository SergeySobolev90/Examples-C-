//  Задача 22
//Найти расстояние между точками в пространстве 2D/3D


int InPut(string message)
{
    Console.Write(message);
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

double DistancePoints2D(double x1, double x2, double y1, double y2)
{
    double rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return rasst;
}

double DistancePoints3D(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return rasst;
}

Console.Write("Выберете пространство 2D или 3D: ");
string space = Console.ReadLine();

if (space == "2D")
{
    double corr1 = InPut("Введите координату х1: ");
    double corr2 = InPut("Введите координату y1: ");
    double corr3 = InPut("Введите координату х2: ");
    double corr4 = InPut("Введите координату y2: ");
    double rasst2D = DistancePoints2D(corr1, corr2, corr3, corr4);
    Console.Write($"Расстояние между двумя точками в пространстве {space}: {rasst2D} ");
}

if (space == "3D")
{
    double corr1 = InPut("Введите координату х1: ");
    double corr2 = InPut("Введите координату y1: ");
    double corr3 = InPut("Введите координату z1: ");
    double corr4 = InPut("Введите координату x2: ");
    double corr5 = InPut("Введите координату y2: ");
    double corr6 = InPut("Введите координату z2: ");
    double rasst3D = DistancePoints3D(corr1, corr2, corr3, corr4, corr5, corr6);
    Console.Write($"Расстояние между двумя точками в пространстве {space}: {rasst3D} ");
}




