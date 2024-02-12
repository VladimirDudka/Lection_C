//                 Двумерный массив
// Двумерный массив - массив, элементами которого являются
// одномерные массивы одинакового размера
//
// Другие названия двумерного массива: 
//  * Таблица
//  * Матрица
//  * Массив массивов
//
//  Характеристики двумерных массивов:
//  * Все свойства, присущие одномерным массивам
//  * В памяти храниться в виде одномерного массива
//
//           Задача_1
// Создать двумерный массив с размерами 3 х 5, 
// состоящий из целых чисел
// Вывести его элементы на экран

// Решение задачи (вар 1)

// Random rnd = new Random();
// int [,] matrix = new int [3,5];
// for (int i = 0; i < matrix.GetLength(0); i++ )
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = rnd.Next(1, 11);
//     }
// }
// Console.Clear();
// for (int i = 0; i < matrix.GetLength(0); i++ )
// {
//     Console.Write("[");
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($" {matrix[i,j]} ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Решение задачи через методы (вар. 2)
int [,] CreateMatrix(int row_count, int colums_count)
{
    Random rnd = new Random();
    int [,] matrix = new int [row_count,colums_count];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i,j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.Write("Введите кол-во столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] the_end = CreateMatrix(row,colums);

Console.Clear();
ShowMatrix(the_end);
Console.WriteLine();











