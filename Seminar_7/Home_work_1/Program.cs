// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N 
// Использовать рекурсию не использовать циклы
void ShowNumbers(int M, int N)
{
    // Базовый случай
    if(M == N)
    {
        //Console.Clear();
        Console.Write($"{M} ");
        Console.WriteLine("END.");
        return;
    }
    // Рекурсивный случай
    Console.Write($"{M} ");
    ShowNumbers(M + 1, N);

    // Раскручивание рекурсии
    Console.Write($"{M} ");
}

// Для проверки в метод ShowNumbers(), нужно добавить входн. параметры
ShowNumbers(5,9);
