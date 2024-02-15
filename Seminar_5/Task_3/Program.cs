int[] SumRows(int[,] array)
{

    int[] arr = new int[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            arr[i] = sum;
        }
        
    }
    return arr;
}

Random rnd = new Random();
int[,] DoubleArray(int row, int colum) // Метод создания двухмерного масива,
//  с произвольными целыми числами от 1 до 10
{
    int[,] arr = new int[row, colum];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void SeeMatrix(int[] arr) // Метод печатающий  массив
{
    Console.Write("|");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"  {arr[i]}");
        
        
    }
    Console.WriteLine("  |");
}

void SeeDoubleMatrix(int[,] arr) // Метод печатающий двумерный массив
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

int MinIndex(int[] array)
    {
       
      int minNumeric = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[minNumeric] > array[i])
        {
          minNumeric = i;
        }
      }
      return minNumeric;
    }


Console.Clear();

Console.Write("Введите кол-во столбцов массива (не более 5): ");
int row = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите кол-во строк массива (не более 5): ");
int colum = Convert.ToInt32(Console.ReadLine()!);

int[,] forPrint = DoubleArray(row, colum);
SeeDoubleMatrix(forPrint);
Console.WriteLine();
Console.WriteLine();
int[] forOut = SumRows(forPrint);
SeeMatrix(forOut);
Console.WriteLine();
Console.WriteLine($"{MinIndex(forOut)}");

