//    Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string StringToLower(string text)
{
    string lower = text;
    lower = lower.ToLower();
    return lower;
}

Console.Clear();
Console.Write("Напишите текст на \"латинице\" с разным регистром : ");
string forPrint = Console.ReadLine()!;
Console.WriteLine();
Console.WriteLine($"Введённый текст : {forPrint}");
Console.WriteLine($"Полученный текст : {StringToLower(forPrint)}");
Console.WriteLine();