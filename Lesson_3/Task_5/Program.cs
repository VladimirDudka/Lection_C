//                   Способ инициализации переменных и массивов.
//                    Инициализация с помощью ввода с консоли.

//  Для ввода информации используется команда ReadLine
//  ReadLine ВСЕГДА возвращает тип string

int size = 9;
int[] arr_int = new int[size];
for (int i =0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} число массива: ");
    string input = Console.ReadLine()!;
    arr_int[i] = Convert.ToInt32(input);
}

Console.Clear();
Console.WriteLine($"Ваш, массив выглядит так : ");
Console.WriteLine($"  [ {string.Join(" ", arr_int)} ] ");