// Задайте произвольный массив.
// Выведите его элементы начиная с конца


// Меняя данную переменную (ввод с клавиатуры), можно выбрать 
// размер массива, который будет создан и заполнен
Console.Clear();
Console.Write("Введите размер одномерного массива который будет создан : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Метод создаёт массив из указанного кол-ва элементов
// и заполняет его случайными числами из указанного промежутка
int[] RandomArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10, 31);
    }
    return arr;
}


int[] enterArray =  RandomArray(size); // Сохраняю полученный результат
int j = enterArray.Length;  // Определяю размер массива для вывода на печать

// Метод выводящий на печать одномерный массив
// в перевернутом виде (reverse). Используется рекурсия.
void PrintReverseArray(int[] arr, int j)
{
    if (j == arr.Length)
    {
        Console.Write("[ ");
    }    
    
    else if (j == 0)
    {
        Console.Write("].");
        return;
    }
    Console.Write($"{arr[j - 1]} ");

    PrintReverseArray(arr, j - 1);
    return;
}


Console.WriteLine($"Полученный массив из {size} элементов: ");
Console.WriteLine($"[ {string.Join(" ", enterArray)} ].");
Console.WriteLine($"Изменённый массив (reverse) из {size} элементов: ");
PrintReverseArray(enterArray, j);
Console.WriteLine();
Console.WriteLine();