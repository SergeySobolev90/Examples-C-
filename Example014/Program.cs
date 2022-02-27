
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(","")
                .Replace(")","") // избавились от скобок спомощью Replace 
                ;               
Console.WriteLine(text);

var data = text.Split(" ")// метод разбивки символа разделителя в данном случае пробел 
                .Select(item => item.Split(',')) // вместо пробела будет использовать запитая 
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0) //вывод только четных координат 
                .Select(point => (point.x * 10, point.y))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]); 
    Console.WriteLine();
}