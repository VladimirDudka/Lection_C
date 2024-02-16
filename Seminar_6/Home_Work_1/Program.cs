//  Задайте двумерный массив символов (тип char[,]).
//  Создайте строку из символов этого массива.


Random randomize = new Random();
// Метод заполнения двухмерного массива
// произвольными латинскими char

char[,] FilingTwoArrayChar(int row, int column)
{
    char[,] arr_char = new char[row, column];
    for (int i = 0 ; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr_char[i, j] = Convert.ToChar(randomize.Next('a', 'z' + 1));
        }
    }
    return arr_char;
}

// Метод печатающий двумерный массив
void SeeDoubleMatrix(char[,] arr) 
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


// Метод для создания строки из введённого
// двумерного массива символов (char)
string StringFromArrayChar(char[,] array)
{
    string charWrite = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            charWrite = charWrite + array[i, j];
        }
    }
    return charWrite;
}

Console.Clear();
Console.Write("Введите колличество строк в (char) массиве : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов в (char) массиве : ");
int column = Convert.ToInt32(Console.ReadLine());
char[,] result = FilingTwoArrayChar(row, column);
Console.WriteLine();
Console.WriteLine($"Из полученого массива: ");
SeeDoubleMatrix(result);
Console.WriteLine();
Console.Write($"Вышла такая строка:  {StringFromArrayChar(result)}");
Console.WriteLine();