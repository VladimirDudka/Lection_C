//               В C#,  ФУНКЦИЯ == МЕТОД .
//     Задача случайный ввод элементов массива
// Задайте массив из N целых чисел (N вводится с клавиатуры)
// массив набирается случайный ввод.
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример:
// [1 5 11 21 81 4 0 91 2 3]
// => 2

int [] CreateArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 201); // Присвоение значений каждому элементу массива
                    // new Random() - Создаём новую функцию. Next(1, 201) - границы для Random                         

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
Console.Clear();
Console.Write("Введите число : "); // Вводим кол-во элементов массива
int N = Convert.ToInt32(Console.ReadLine()); // Переводим введеный string в int и сохраняем в N
int [] result = CreateArray(N); // Создаём новый массив с помощью метода CreateArray()
int var = GetCount(result); // Метод GetCount() считает сколько совпадений в массиве с условием
Console.WriteLine($"Массив : [ {string.Join(" | ", result)} ]");
Console.WriteLine($"Кол-во совпавших с условием чисел : {var} ");
Console.WriteLine();




