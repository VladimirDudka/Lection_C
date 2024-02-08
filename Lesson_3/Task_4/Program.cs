//                Генерация случайных чисел.
//
//  Random - Тип данных "Генератор случайных чисел"
//  rnd - Имя переменной
//  new Random() - создание объекта

Random rnd = new Random(); // Объект типа Random (переменная rnd только ссылается на объект)
// Заполнение массива
int size = 256;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(-9, 10);
    i += 1;
}

// Вывод на экран массива
i = 0;
while (i < size)
{
    Console.Write($"{arr_int[i]} ");
    i += 1;
}
Console.WriteLine();

