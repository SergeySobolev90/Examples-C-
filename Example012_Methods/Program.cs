// Вид 1

void Merthod1() // Метод ничего не возвращает, не принимает аргументы 
{
    Console.WriteLine("Автор SergeyS");
}
//Merthod1();


// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения"); 

void Method21(string msg, int count) // Метод и его (аргументы)
{
    int i = 0;
    while (i < count) // цикл 
    {
        Console.WriteLine(msg);  // тело цикла 
        i++; // i счетчик
    }
}
//Method21(msg:"Текст", count: 4);
//Method21(count: 4, msg: "Новый текст"); // не обязательно писать по порядку артгументы 


// Вид 3  если метод, что-то возвращет не обходимо указать тип данный (int, string, var)

int Method3() // не принемает аргументы 
{
    return DateTime.Now.Year;   // обязательное использование оператора (return)-возвращение
}
int year = Method3(); // вызываем метод или его индефикатор, 
//в левой чисти мы можем использовать индефикатор переменной (int year)
//Console.WriteLine(year); //используем переменную (year)
// и то знаение, которое нам вернул метод, те вычисление, которые произошли в теле Метода

// Вид 4 самая важная группа методов, которые что-то принимаю и что-то возвращают

/*string Method4(int count, string text) // метод и его аргументы 
{
    int i = 0; // Вводные данные 
    string result = String.Empty; // String.Empty означает, что result изнаально будет пустой строкой
    
    while(i < count)
    {
        result = result + text; // добавляем result и присваеваем к нет строчку text
        i++;
    }
    return result; // используем оператор return записываем в него переенную 
    //result, которую ожидаем получить из Метода 
}

string res = Method4(10, "s");
Console.WriteLine(res);
// для того чтобы вызвать данный метоод необходимо создать нужную нам переменную */

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)   //  цикл for сначала идет инициализация счетчика, 
    //после проверка условия и сюда же записывает энкримент(Увеличение счетчика)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "s");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++) // для этого первого цикла оператором выступает второй цикл ниже 
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} x {j} = {i*j}"); //интерполяция строк $ 
    }
    //Console.WriteLine();
}

// == Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// меленькие буквы "к" заменить большими "К", а боьшие "С" заменить на меленькие "с"

string text = "-Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежеле бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r 

// 4 вид методов

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализация пустой строки 
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // если символ в тексте = тому символу, который мы хотим заменить, в result положим новый символ
        else result = result + $"{text[i]}";   // если же совпадений не обнаружено, то в наш result нужно добавть текущий символ, который как раз таки и был 
    }

    return result;
}

string newText = Replace(text, ' ', '|');

//Console.WriteLine(newText);
//Console.WriteLine();
newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);
//Console.WriteLine();
newText = Replace(newText, 'с', 'С');
//Console.WriteLine(newText);

// Упорядочь Массив
// Сортировка 

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // массив 
// подзадача для того чтобы вывести масси на экран 
// напише отдельный метод void

void PrintArray(int[] array) // в качетсве аргумента массив 
{
     int count =array.Length;

     for (int i = 0; i < count; i++) // цикл for
     {
         Console.Write($"{array[i]} "); //  вывод в одну строку 
     }
     Console.WriteLine();
}


// Следующим действием нужно написать метод, который будет упорядочивать наш массив 

void SelectionSoft(int[] array)
{
     for (int i = 0; i < array.Length -1; i++)
     {
         int minPosition = i; // запишим позицию на которую смотрим и запоминаем позицию рабочего элемента (i) индекс
         
         for (int j = i + 1; j < array.Length; j++)
         {
             if(array[j] < array[minPosition]) minPosition = j;
         }
         int temporary = array[i]; // нам потребуется поменять значение minPosition с той позициикотррую мы здесь нашли
         array[i] = array[minPosition]; // нужно будет положить значение minPosition
         array[minPosition] = temporary;
     }
}

PrintArray(arr);
SelectionSoft(arr);

PrintArray(arr);


