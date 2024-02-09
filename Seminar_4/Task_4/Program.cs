//               В C#,  ФУНКЦИЯ == МЕТОД .
//  Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр
// данного массива. Пример: [2, 7, 4] => 274


// Метод создаёт массив из указанного кол-ва элементов
// и заполняет его случайными числами из указанного промежутка

int[] RandArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

// Метод склеивает элементы переданного массива в одно число
// Пример: [2, 7, 4] => 274

int paste_togetherArray(int[] array)
{
    int glue_number = int.Parse(string.Join("", array));
    return glue_number;
}

// Ввод данных и запуск метода
Console.Clear();
Console.Write($"Введите кол-во элементов массива от 1 до 8 : ");
int N = Convert.ToInt32(Console.ReadLine());

// проверка на N (вводится с консоли, не более 8)
if (N < 1 | N > 8)
{
    Console.WriteLine($"Внимательно читай условие!");
}
else
{
    int[] method = RandArray(N);
    Console.WriteLine();
    Console.WriteLine($" Массив : [ {string.Join(" : ", method)} ]");
    Console.WriteLine($" Число :  {paste_togetherArray(method)}.");
    Console.WriteLine();
}
