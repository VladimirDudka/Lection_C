//   Задача 3: 
// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

bool Pallindrom(string text)
{   
    bool flag = true;
    string ext = text.ToLower().Replace(" ", ""); // В тексте меняется регистр на строчный
                                                  // и удаляются все пробелы
    int last_char = ext.Length - 1;   // Находим регистр последнего символа
    for (int i = 0; i <= ext.Length/2; i++)  // Запускаем цикл сравнения первого и последнего символа
    {
        if (ext[i] != ext[last_char])
        {
            flag = false;
            break;
        }
        last_char = last_char - 1;
    }
    return flag;
}
Console.Clear();

// Далее идут строки для проверки,
// комментируя и раскомент. строки на проверку

// string first = "А роза упала на лапу Азора";
// string first = "Мат и тут и там";
// string first = "Аргентина манит негра";
string first = "Уж реДко рУкою окурОк дерЖу";
// string first = "Шалаш";
// string first = "мАдам";
// string first = "каБан ";


Console.WriteLine($"Полученный текст : {first}");
Console.WriteLine($"Ответ : {Pallindrom(first)}");
Console.WriteLine();

