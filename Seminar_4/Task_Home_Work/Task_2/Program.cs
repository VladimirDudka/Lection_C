// Задача 2 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] RandomThreeArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int CountEvenArray(int [] array)
{
    int count_even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count_even = count_even + 1;
        }

    }
    return count_even;
}


Console.Clear();
Console.Write($"Введите размер массива от 2 до 8 : ");
int number = Convert.ToInt32(Console.ReadLine());

int [] three_arr = RandomThreeArray(number);

Console.WriteLine($"Ваш массив выглядит так : [ {string.Join(" : ", three_arr)} ].");
Console.WriteLine($"Колличество чётных чисел в нём : {CountEvenArray(three_arr)}");

