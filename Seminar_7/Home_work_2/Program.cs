// Напишите программу вычисления функции Аккермана с помощью рекурсии
// Даны два неотрицательных числа n и m


// Калькулятор функции Аккермана
int TheAckermannFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return TheAckermannFunction(n - 1, 1);
    }
    return TheAckermannFunction(n - 1,TheAckermannFunction(n, m - 1) );
}

Console.Clear();
Console.WriteLine("  *** Онлайн калькулятор формулы Аккермана ***");
Console.WriteLine();

Console.Write("Введите число (n) : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число (m) : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Результат функции Аккермана с n = {n} и m = {m} равен {TheAckermannFunction(n, m)}.");
Console.WriteLine();
