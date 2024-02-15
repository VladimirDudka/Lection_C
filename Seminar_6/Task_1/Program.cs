//  Задайте массив символов (тип char[]).
//  Создайте строрку из  символов 
//  этого массива.
//  ['a', 'b', 'c', 'd'] => "abcd"

string GetString (char[] array)
{
    string result = string.Empty; // в народе это - ""
    foreach (char e in array)
    {
        result += e;
    }
    return result;
}
char[] chars = {'1', 'd', '!', '2', '@', 'h', 'G'};
Console.Clear();
Console.WriteLine($"Массив пример : [ {string.Join(" + ", chars)} ].");
string total = GetString(chars);
Console.WriteLine(total);