// Задача 16 
// Дано число обозначающие день недели. Выяснить является номер дня недели выходным 


Console.Write("Введите число от 1 до 7: ");

int dayWeek = 0;
while (dayWeek <= 0 || dayWeek >= 8)
{
    string dayWeekStr = Console.ReadLine();
    int.TryParse(dayWeekStr, out dayWeek);
}

int[] dayWeekNumber = { 1, 2, 3, 4, 5, 6, 7 };
if (dayWeek < 6)
{
    Console.WriteLine($"Номер: {dayWeekNumber[dayWeek - 1]} является будним днем ");
}
else
{
    Console.WriteLine($"Номер: {dayWeekNumber[dayWeek - 1]} является выходным днем ");
}