//               В C#,  ФУНКЦИЯ == МЕТОД .
//     Задача ручной ввод элементов массива
// Задайте массив из N целых чисел (N вводится с клавиатуры)
// массив также набирается с клавиатуры.
// Найдите количество чисел, которые оканчиваются на 1 и делятся нцело на 7.
// Пример:
// [1 5 11 21 81 4 0 91 2 3]
// => 2

int [] CreateArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine();
        Console.Write($"Введите {i + 1} элемент массива : ");
        array[i] = Convert.ToInt32(Console.ReadLine()!);
    }
    return array;

}

Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int [] result = CreateArray(N);
Console.WriteLine($"Массив : [ {string.Join(" | ", result)} ]");





