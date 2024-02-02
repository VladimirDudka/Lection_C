// Цикл foreach .
//
// FOREACH (англ.) дословный перевод -
// ДЛЯ_КАЖДОГО - FOREACH
//
int[] array = {1, 3, 5, 7, 9}; // Создаём массив

foreach (int e in array)       // В цикле foreach создаётся переменная e,
                               // которая принимает значение каждого элемента
                               // массива по очереди пока идёт цикл
{
    Console.Write($"{e} ");    // Выводим переменную е в терминал пока идёт цикл
}
Console.WriteLine($"");


// Поиск наименьшего числа в массиве 
int[] arr = {3,6,2,8,1};
int min = arr[0];
foreach (int numero in arr)
{
    if (min > numero)
    {
        min = numero;
        Console.WriteLine($"Новый минимум равен {numero}");
    }
}
Console.WriteLine($"Наименьшее число равно - {min}.");



