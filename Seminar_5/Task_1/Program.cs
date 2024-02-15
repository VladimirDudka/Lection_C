// Задайте двумерный массив. Найдите элементы, у которых оба
// числа чётные, замените эти элементы на их квадраты.

Random rnd = new Random();
int[,] DoubleArray(int row, int colum) // Метод создания двухмерного масива,
//  с произвольными целыми числами от 10 до 99
{
    int[,] arr = new int[row, colum];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i, j] = rnd.Next(10, 100);
        }
    }
    return arr;
}

int[,] ChangeElements(int[,] arrForChange) // Метод находит элементы, у которых оба
//    числа чётные, заменяет эти элементы на их квадраты.
{
    for (int i = 0; i < arrForChange.GetLength(0); i++)
    {
        for (int j = 0; j < arrForChange.GetLength(1); j++)
        {
            int temp = arrForChange[i, j];
            if ((temp / 10) % 2 == 0 && (temp % 10) % 2 == 0)
            {
                temp *= temp;
                arrForChange[i, j] = temp;
            }
        }
    }
    return arrForChange;
}

void SeeMatrix(int[,] arr) // Метод печатающий двумерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"  {arr[i, j]}");
        }
        Console.WriteLine("  |");
    }
}

void SeeMatrix(int[,] arr) // Метод печатающий двумерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"  {arr[i, j]}");
        }
        Console.WriteLine("  |");
    }
}

Console.Clear();

Console.Write("Введите кол-во столбцов массива (не более 5): ");
int row = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите кол-во строк массива (не более 5): ");
int colum = Convert.ToInt32(Console.ReadLine()!);

int[,] forPrint = DoubleArray(row, colum);

Console.WriteLine($"Полученный массив : ");
SeeMatrix(forPrint);
Console.WriteLine();

Console.WriteLine($"Изменёный массив : ");
SeeMatrix(ChangeElements(forPrint));
Console.WriteLine();
