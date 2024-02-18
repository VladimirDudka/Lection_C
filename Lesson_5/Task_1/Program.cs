//                                РЕКУРСИЯ
//         Задача_1
//  Вычислить факториал от натурального числа N
int FindFactorial(int N)
{

    // Базовый случай
    if (N == 1 || N == 0)
    {
        Console.WriteLine($"Stop reqursion : N = {N}");
        return 1;
    }

    // Рекурсивный случай
    Console.WriteLine(N);
    int res = N * FindFactorial(N - 1);
    Console.WriteLine($"Возврат: N = {N}, Factorial = {res}");
    return res;
}
int simplyDigit = 5;
Console.WriteLine($"Факториал числа {simplyDigit} равен {FindFactorial(simplyDigit)}");