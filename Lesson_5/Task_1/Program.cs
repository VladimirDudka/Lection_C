//                                РЕКУРСИЯ
//         Задача_1
//  Вычислить факториал от натурального числа N
int FindFactorial(int N)
{
    // Базовый случай
    if(N == 1)
    {
        return 1;
    }

    // Рекурсивный случай
    return N * FindFactorial(N - 1);
}


Console.WriteLine(FindFactorial(5));