//               В C#,  ФУНКЦИЯ == МЕТОД .
//     Задача ручной ввод элементов массива
// Задайте массив из N целых чисел (N вводится с клавиатуры)
// массив также набирается с клавиатуры.
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример:
// [1 5 11 21 81 4 0 91 2 3]
// => 2


// Метод создаёт массив из указанного кол-ва элементов
// и заполняет его, пользователь с клавиатуры.
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

// Метод ищет количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
        {
            count++;
        }
    }
    return count;
}

// Вызов метода. Вывод массива после заполнения
Console.Clear(); // Отчистка терминала
Console.Write("Введите число : "); // Вводим кол-во элементов массива
int N = Convert.ToInt32(Console.ReadLine()); // Переводим введеный string в int и сохраняем в N
int [] result = CreateArray(N); // Создаём новый массив с помощью метода CreateArray()
int var = GetCount(result); // Метод GetCount() считает сколько совпадений в массиве с условием

Console.Clear(); // Отчистка терминала
Console.WriteLine($"Массив : [ {string.Join(" | ", result)} ]");
Console.WriteLine($"Кол-во совпавших с условием чисел : {var} ");
Console.WriteLine();




