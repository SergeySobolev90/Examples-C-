//Задача 18 
//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// ¬ знак отрицания 
// ⋁ логическое "И" дизьюнкция 
// ⋀ логическое "ИЛИ" коньюнция

void TruthOfTheStatements( bool x, bool y)
{
    Console.WriteLine($"!({x} || {y}) = {!(x || y)}, !{x} && !{y} = {!x && !y}");
}

TruthOfTheStatements(true, false);
TruthOfTheStatements(false, true);
TruthOfTheStatements(true, true);
TruthOfTheStatements(false, false);

