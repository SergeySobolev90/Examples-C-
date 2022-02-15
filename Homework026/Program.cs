//  Задача 26 
// Возвести число А в натуральную степень числа В используя цикл 


Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int numberB = int.Parse(Console.ReadLine());
int numberA_numberB = 1;
for (int i = 0; i < numberB; i++)
    numberA_numberB *= numberA;
Console.WriteLine("{0} ^ {1} = {2}", numberA, numberB, numberA_numberB);

