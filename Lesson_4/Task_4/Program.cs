//                 Задача_3
//  Считать с консоли строку, 
//  состоящую из цифр и латинских букв
//  Сформировать новую строку, состоящую
//  из букв исходной строки.
//
//  Этапы решения:
// 1. Ввод строки
// 2. Проход по элементам строки
// 3. Проверка элемента: является ли он буквой?
// 4. Дописать подходящий элемент к новой строке
 

 string OnlyLatters(string var)
 {
    string letters = "";
    foreach(char e in var) // 2. Проход по элементам строки
    {
        if( Char.IsDigit(e) == false) // 3. Проверка элемента: является ли он буквой?
        {
            letters = letters + e;  // 4. Дописать подходящий элемент к новой строке
        }
    }
    return letters;
 }

Console.Clear();
Console.Write("Введите строку состоящую из цифр и латинских букв : ");
string mix_char = Console.ReadLine()!;
Console.WriteLine();
Console.WriteLine($"Введеная строка - {mix_char}.");
Console.WriteLine($"Изменёная строка - {OnlyLatters(mix_char)}.");
Console.WriteLine();