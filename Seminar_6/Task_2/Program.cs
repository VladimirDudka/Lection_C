//   На основе символов строки (тип string)
//  сформировать массив символов.
//  Вывести массив на экран.
// "Hello!" = ['H', 'e', 'l', 'l', 'o', '!']

char[] InStringOutChar(string text)
{
    char[] symbols = new char[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        symbols[i] = text[i];
    }
    return symbols;
}
Console.Clear();
string str = "Hello world!";
Console.WriteLine($"Строка входа - {str}");
char[] chars = InStringOutChar(str);
Console.WriteLine($"Полученный массив - [ {string.Join(" _ ", chars)}]");
