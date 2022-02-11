// Задача 16 
// Дано число обозначающие день недели. Выяснить является номер дня недели выходным 


Console.Write("Введите число от 1 до 7: ");

int dayWeek = 0;
while (dayWeek <= 0 || dayWeek >= 8)
{
    string dayWeekStr = Console.ReadLine();
    int.TryParse(dayWeekStr, out dayWeek);
}

string[] dayWeekNumber = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (dayWeek < 6)
    Console.WriteLine($"{dayWeekNumber[dayWeek - 1]} будний день ");
else
    Console.WriteLine($"{dayWeekNumber[dayWeek - 1]} выходной день ");