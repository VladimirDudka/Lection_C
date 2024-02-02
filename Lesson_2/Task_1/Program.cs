// Массив - структура данных,
// хранящая набор однотипных элементов

// имя_массива[индекс элемента массива]
// int[] arr = new int[5];
// 1. Тип: int (целочисленный), [] - кв.скобки указывают на создание массива
// 2. Имя: arr / Имя для массива нужно подбирать максимально подходящим по значению
// 3. Выделение памяти: 
//     оператор new - открывает массив целочисленный на 5 элементов

int[] arr = new int [5]; // Метод создания массива
arr[0] = 5;
arr[1] = 2;
arr[2] = 1;
arr[3] = 4;
arr[4] = 3;
// Вывод элементов массива
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);
//Console.WriteLine(arr[5]); // выход за предел массива



int[] arr_2 = new int [5] {1,7,5,4,2}; // Второй метод создания массива
// Вывод элементов массива
Console.Write(arr_2[0] + ", ");
Console.Write(arr_2[1] + ", ");
Console.Write(arr_2[2] + ", ");
Console.Write(arr_2[3] + ", ");
Console.WriteLine(arr_2[4] + ".");



int[] arr_3 = {12,18,14,15,13}; // Третий метод создания массива
// Вывод элементов массива
Console.WriteLine(arr_3[0]);
Console.WriteLine(arr_3[1]);
Console.WriteLine(arr_3[2]);
Console.WriteLine(arr_3[3]);
Console.WriteLine(arr_3[4]);
