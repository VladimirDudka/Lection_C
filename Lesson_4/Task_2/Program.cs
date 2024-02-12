//        Способы создания двумерного массива в C#
//
//   int[,] table_1 = new int[2,4] {
//      {1,1,1,1},
//      {2,2,2,2}
//      };
//
//  * При таком заполнении массива размеры можно не указывать
//   int[,] table_1 = new int[,] {
//      {1,1,1,1},
//      {2,2,2,2}
//      };
//
//
//  * Самый компактный способ. По заполненому массиву компилятор 
//    сам сгенерирует массив нужного размера
//   int[,] table_1 = {
//      {1,1,1,1},
//      {2,2,2,2}
//      };
//

Random rnd = new Random();

int [,] ArrayTwoLine (int row, int colum) // Метод для создания двумерного массива
{
    int [,] array = new int[row, colum]; // создаём двумерный массив
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(10,100); // двумя циклами заполняем каждый элемент
                                           // массива произвольными числами от 10 до 99
        }
    }
    return array; // возвращаем полученный массив
}

void PrintIntrestingNumber(int [,] int_arr) // Метод для определения "интересного" числа
                                            // в двумерном массиве. Если число каждого элемента
                                            // суммируется (десятки + единицы) и сумма кратна 2,
                                            // оно является "интересным" числом.  
{
    for(int i = 0; i < int_arr.GetLength(0); i++)
    {
        for(int j = 0; j < int_arr.GetLength(1); j++)
        {
            int sum = (int_arr[i,j] / 10) + (int_arr[i,j] % 10) ;
            if (sum % 2 == 0) // двумя циклами проверяемяем каждый элемент массива
                              // является ли элемент "интересным" числом
            {
                Console.WriteLine($"Число {int_arr[i,j]} в массиве[{i}, {j}] является \"Интересным\", сумма цифр чётная = {sum}.");
            }
        }
    }
}

void ShowMatrix(int [,] matrix) // Метод печатающий двумерный массив
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

Console.Write("Введите колличество строк: ");
int horizont_line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите колличество столбцов: ");
int vertical_line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int [,] unit = ArrayTwoLine(horizont_line,vertical_line);

ShowMatrix(unit);
PrintIntrestingNumber(unit);

Console.WriteLine();
