// Задача 3 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int [] ReverseArray (int [] arr)
{
    int half = arr.Length % 2;
    int i = 0;
    int j = arr.Length - 1;
    while (i < j)
    {
        int var = arr[j];
        arr[j] = arr[i];
        arr[i] = var;
        j--;
        i++;
    }

    return arr;     
}


int [] MakeArray (int size)
{
    int [] array = new int[size];
    for (int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(20);
    }
    return array;
}

Console.Clear();
Console.Write($"Введите размер массива (от 2 и не более 10) : ");

int number = Convert.ToInt32(Console.ReadLine()!);
if (number > 1 && number <= 10 )
{
    int [] exit = MakeArray(number);

    Console.WriteLine($"Получившийся массив - [ {string.Join(" , ", exit)} ]. ");
    Console.WriteLine($"Перевёрнутый массив - [ {string.Join(" , ", ReverseArray(exit))} ]. ");
    Console.WriteLine();
}
else
{
    Console.WriteLine($"Не выполнено условие ввода !");
    Console.WriteLine();
}
