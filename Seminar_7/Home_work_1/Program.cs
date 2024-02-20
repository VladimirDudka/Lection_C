// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N 
// Использовать рекурсию не использовать циклы
void ShowNumbers(int M, int N)
{
    // Базовый случай
    if(M == N)
    {
        Console.Write($"{M} ");
        Console.WriteLine("END.");
        return;
    }
    // Рекурсивный случай
    Console.Write($"{M} ");
    ShowNumbers(M + 1, N);

    // Раскручивание рекурсии
    // Console.Write($"{M} ");
}

Console.Clear();

Console.WriteLine("Программа, выведет все натуральные числа из указанного промежутка.");
Console.WriteLine();

Console.Write($"Введите натуральное число (M), точка старт промежутка : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите натуральное число (N), точка конец промежутка : ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
ShowNumbers(M,N);

Console.WriteLine();